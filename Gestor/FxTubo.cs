using System.Linq;
using Gestor.Models;
using System;

namespace Gestor
{
    public static class FxTubo
    {
        public static float ResinaAdotada(ProcTubo procTubo)        // L
        {
            var db = new ApplicationDbContext();
            string resinaBase = XmlReader.Read("Transl");
            float result = 0;

            if (procTubo.ResinaBase.Apelido == resinaBase)
            {
                string comp = XmlReader.Read("PadraoFixo19");
                result = db.PadroesFixos.SingleOrDefault(pf => pf.Descricao == comp).Valor;
            }

            else
            {
                resinaBase = XmlReader.Read("BrancoB");

                if (procTubo.ResinaBase.Apelido == resinaBase)
                {
                    string comp = XmlReader.Read("PadraoFixo17");
                    result = db.PadroesFixos.SingleOrDefault(pf => pf.Descricao == comp).Valor;
                }

                else
                {
                    string comp = XmlReader.Read("PadraoFixo18");
                    result = db.PadroesFixos.SingleOrDefault(pf => pf.Descricao == comp).Valor;
                }
            }

            return result;
        }


        public static float RrMaxResina(ProcTubo procTubo)
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var resina = db.ResinasPtfe.SingleOrDefault(r => r.Ref == procTubo.CodResinaAdotada);
            if (resina == null) DbLogger.Log(Reason.Error, $"Resina {procTubo.CodResinaAdotada} não encontrada em RrMaxResina");
            else result = resina.MaxRr;

            return result;
        }

        public static float BicoIdeal(ProcTubo procTubo)
        {
            float result = 0;

            if (procTubo.Sinterizado)
            {
                result = procTubo.ResinaBase.Apelido == XmlReader.Read("Branco")
                    ? 0.97f
                    : 0.93f;
            }

            else result = 1;

            return Function.Ceiling(procTubo.DiamExterno / result, 0.05f);
        }

        public static float MandrilIdeal(ProcTubo procTubo)
        {
            float result = 0;

            if (procTubo.Sinterizado)
            {
                result = procTubo.ResinaBase.Apelido == XmlReader.Read("Branco")
                    ? 0.97f
                    : 0.93f;
            }

            else result = 1;

            return Function.Ceiling(procTubo.DiamInterno / result, 0.05f);
        }

        public static float SecaoExtrudado(ProcTubo procTubo)
        {
            return (procTubo.BicoIdeal * procTubo.BicoIdeal - procTubo.MandrilIdeal * procTubo.MandrilIdeal) * (float)Math.PI / 4;
        }

        public static float PerimSecaoExtrud(ProcTubo procTubo)     // Q
        {
            float result = procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente")
                ? procTubo.BicoIdeal * (float)Math.PI / (procTubo.BicoIdeal * procTubo.BicoIdeal - procTubo.MandrilIdeal * procTubo.MandrilIdeal) * (float)Math.PI / 4
                : 0;

            return result;
        }

        public static float DiamExtFinalTubo(ProcTubo procTubo)
        {
            float result = 0;

            if (procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente"))
            {
                if (procTubo.Sinterizado)
                {
                    result = procTubo.ResinaBase.Apelido == XmlReader.Read("Branco")
                        ? 0.97f
                        : 0.93f;
                }

                else result = 1;
            }

            return procTubo.BicoIdeal * result;
        }

        public static float DiamIntFinalTubo(ProcTubo procTubo)
        {
            float result = 0;

            if (procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente"))
            {
                if (procTubo.Sinterizado)
                {
                    result = procTubo.ResinaBase.Apelido == XmlReader.Read("Branco")
                        ? 0.97f
                        : 0.93f;
                }

                else result = 1;
            }

            return procTubo.MandrilIdeal * result;
        }

        public static float PesoUnKgMLiq(ProcTubo procTubo)     // T
        {
            var db = new ApplicationDbContext();
            float intermidiate = (procTubo.DiamExtFinalTubo * procTubo.DiamExtFinalTubo - procTubo.DiamIntFinalTubo * procTubo.DiamIntFinalTubo) * (float)Math.PI / 4;
            float result = procTubo.Sinterizado
                ? intermidiate * db.PadroesFixos.Single(p => p.Descricao == XmlReader.Read("DensidadeCordaoSeco")).Valor
                : intermidiate * db.PadroesFixos.Single(p => p.Descricao == XmlReader.Read("DensidadePadraoSinterizado")).Valor;

            return result;
        }

        public static float PtfeKgM(ProcTubo procTubo)      // U
        {
            var db = new ApplicationDbContext();
            var sucata = db.PadroesFixos.Single(p => p.Descricao == XmlReader.Read("SucatasAparasTubos"));
            float result = sucata == null
                ? 0
                : procTubo.PesoUnKgMLiq / (1 - sucata.Valor) * (1 - procTubo.PctCarga1) * (1 - procTubo.PctCarga2);

            return result;
        }

        public static float LubrKgM(ProcTubo procTubo)      // V
        {
            var db = new ApplicationDbContext();
            var sucata = db.PadroesFixos.Single(p => p.Descricao == XmlReader.Read("SucatasAparasTubos"));
            var lubrificante = db.PadroesFixos.Single(p => p.Descricao == XmlReader.Read("LubrificantePctPadrao"));
            float intermediate = (procTubo.PesoUnKgMLiq / (1 - sucata.Valor)) * lubrificante.Valor;
            int round = intermediate * 1_000 > 10
                ? 3
                : 4;

            return (float)Math.Round(intermediate, round);
        }

        public static int CodPreformaIdeal(ProcTubo procTubo)     // W
        {
            int result = 0;

            if (procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente"))
            {
                if (7359 / procTubo.SecaoExtrudado <= procTubo.RrMaxResina) result = 5;
                else
                {
                    if (4533 / procTubo.SecaoExtrudado <= procTubo.RrMaxResina) result = 4;
                    else
                    {
                        if (2543 / procTubo.SecaoExtrudado <= procTubo.RrMaxResina) result = 3;
                        else
                        {
                            if (904 / procTubo.SecaoExtrudado <= procTubo.RrMaxResina) result = 2;
                            else result = 1;
                        }
                    }
                }
            }

            return result;
        }

        public static float Rr(ProcTubo procTubo)     // X
        {
            float result = 0;

            if (procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente"))
            {
                var db = new ApplicationDbContext();
                var preforma = db.PreFormas.SingleOrDefault(p => p.PreFormaNum == procTubo.CodPreformaIdeal);
                if (preforma == null) DbLogger.Log(Reason.Error, $"Preforma {procTubo.CodPreformaIdeal} não encontrada em Rr");
                else result = (float)Math.Round(preforma.SecaoPf * 100 / procTubo.SecaoExtrudado, 1);
            }

            return result;
        }

        public static int LanceSinterizado(ProcTubo procTubo)       // Y
        {
            int result = 0;

            if (procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente"))
            {

            }

            return result;
        }
    }
}