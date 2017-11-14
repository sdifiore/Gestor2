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
            var db = new ApplicationDbContext();
            int result = 0;

            if (procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente"))
            {
                var comprimento = db.PreFormas.SingleOrDefault(p => p.PreFormaNum == procTubo.CodPreformaIdeal);

                if (comprimento != null)
                {
                    var sucata = db.PadroesFixos.Single(p => p.Descricao == XmlReader.Read("SucatasAparasTubos"));
                    result = Function.Floor(comprimento.Comprimento / 1_000f * procTubo.Rr * (1 - sucata.Valor) * 0.65f, 5);
                }
            }

            return result;
        }

        public static float VelEfetExtrusaoMMin(ProcTubo procTubo)      // AO
        {
            var db = new ApplicationDbContext();
            float result = 0;

            if (!procTubo.ProcessoContinuo)
            {
                var comprimento = db.PreFormas.SingleOrDefault(p => p.PreFormaNum == procTubo.CodPreformaIdeal);

                if (comprimento != null)
                {
                    result = procTubo.LanceSinterizado / (comprimento.Comprimento / 1_000 * procTubo.Rr /
                        (procTubo.VextrUmidoMin * procTubo.FatorMultiplVExter) + comprimento.TrocaPf);
                }
            }

            return result;
        }

        public static float VextrUmidoMin(ProcTubo procTubo)        // AE
        {
            float result = 0;

            if (procTubo.Produto.Apelido != XmlReader.Read("ProdutoNaoExistente"))
            {
                result = (float)Math.Round(-3.7755 * Math.Log10(procTubo.BicoIdeal) + 18.609);
            }

            return result;
        }

        public static float VsintMMin(ProcTubo procTubo)        // AG
        {
            float intermidiate = procTubo.Sinterizado ? 1 : 2;

            return (float)Math.Round(0.7862f * Math.Pow(procTubo.PerimSecaoExtrud, 0.9191) * intermidiate, 1);
        }

        public static float VSintResultante(ProcTubo procTubo)      // AI
        {
            return procTubo.VsintMMin * procTubo.FatorMultiplVelSint;
        }

        public static float TuSinterizadoMinM(ProcTubo procTubo)        // AP
        {
            string temp = XmlReader.Read("OcupacaoMOSinterizacao");
            var db = new ApplicationDbContext();
            float ocupacao = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;

            return (float)(Math.Round(1 / procTubo.VsintMMin, 3) / ocupacao);
        }

        public static float TuProducaoMinM(ProcTubo procTubo)       // AQ
        {
            var db = new ApplicationDbContext();
            string temp = XmlReader.Read("EficPadraoOpTubo");
            float eficacia = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            float result = procTubo.VelEfetExtrusaoMMin < Global.Tolerance
                ? procTubo.TuSinterizadoMinM / eficacia
                : (procTubo.VelEfetExtrusaoMMin + procTubo.VelEfetExtrusaoMMin) / eficacia;

            return result;
        }

        public static float QtPCusto(ProcTubo procTubo)     // BG
        {
            var db = new ApplicationDbContext();
            string temp = XmlReader.Read("LoteMinTubos2");
            float a = 60 * db.PadroesFixos.Single(p => p.Descricao == temp).Valor / procTubo.TuProducaoMinM;
            float b = procTubo.LanceSinterizado * procTubo.FatorMultiplQtde;
            float result = a > b ? a : b;

            return Function.Ceiling(result, procTubo.LanceSinterizado);
        }

        public static int QtPf(ProcTubo procTubo)       // AA
        {
            return (int)Math.Ceiling(procTubo.QtPCusto / procTubo.LanceSinterizado);
        }

        public static float ConfAdtDosLub(ProcTubo procTubo)        // AK
        {
            var db = new ApplicationDbContext();
            string temp = XmlReader.Read("EficPadraoOpTubo");
            float eficacia = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("TaxaOcupacaoMOPesagem");
            float ocupacao = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("TempoDosagemLub");
            float tempo = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            float count = 0;
            if (procTubo.Carga1.Apelido != "ND") count++;
            if (procTubo.Carga2.Apelido != "ND") count++;
            if (procTubo.PctCarga1 > Global.Tolerance) count++;

            return count * tempo / procTubo.QtPCusto / eficacia * ocupacao;
        }

        public static float Peneiramento(ProcTubo procTubo)     // AL
        {
            var db = new ApplicationDbContext();
            string temp = XmlReader.Read("EficPadraoOpTubo");
            float eficacia = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("TempoPeneiramento");
            float tempo = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("TaxaOcupacaoMOPesagem");
            float ocupacao = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;

            return procTubo.PesoUnKgMLiq * tempo / eficacia * ocupacao;
        }

        public static float MisturaMinM(ProcTubo procTubo)      // AM
        {
            var db = new ApplicationDbContext();
            string temp = XmlReader.Read("TempoPadraoMistura"); //25
            float tempo = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("EficPadraoOpTubo"); //9
            float eficacia = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("TempoOcupacaoMOMIstura"); //31
            float ocupacao = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;

            return tempo / procTubo.QtPCusto / eficacia * ocupacao;
        }

        public static float PreparoExtrusMinM(ProcTubo procTubo)      // AN
        {
            var db = new ApplicationDbContext();
            string temp = XmlReader.Read("TempoPadraoPrepExtrusora"); //26
            float tempo = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("EficPadraoOpTubo"); //9
            float eficacia = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("TaxaOcupacaoMOExtrusora"); //33
            float ocupacao = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;

            return tempo / procTubo.QtPCusto / eficacia * ocupacao;
        }

        public static float TuInspUdc3MinM(ProcTubo procTubo)       // AR
        {
            var db = new ApplicationDbContext();
            string temp = XmlReader.Read("VelPadraoInspecUDC3"); //37
            float velocidade = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("EficPadraoOpTubo"); //9
            float eficacia = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;
            temp = XmlReader.Read("TaxaOcupacaoMOInspecao"); //30
            float ocupacao = db.PadroesFixos.Single(p => p.Descricao == temp).Valor;

            return 1 / velocidade / eficacia * ocupacao;
        }

        public static float TuTesteEstanqMinM(ProcTubo procTubo)        // AS
        {
            float result = 0;

            if (procTubo.TesteEstqEsto)
            {
              
            }

            return result;
        }
    }
}