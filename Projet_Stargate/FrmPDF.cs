using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfiumViewer;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Stargate
{
    public partial class FrmPDF : Form
    {
        private string cheminPdfTemporaire;

        private PdfiumViewer.PdfDocument pdfAffichage;

        private string nomMission = "";
        private string dateDepart = "";
        private string dateArrivee = "";
        private string nomChef = "";
        private string budgetInitial = "";
        private string txtFeuilleRoute = "";
        private List<string> membres;
        private int nbJours = 0;
        private List<string> evenements;
        private List<string> captures;
        private int sommeVersee = 0;
        private int depenses = 0;
        private int soldeApresDepense = 0;
        private List<string> contactsInformateurs;

        public FrmPDF(string nomMission, string dateDepart, string dateArrivee, string nomChef, string budgetInitial, string txtFeuilleRoute, List<string> membres, int nbJours, List<string> evenements, List<string> captures, int depenses, int sommeVersee, List<string> contacts)
        {
            InitializeComponent();
            PdfSharp.Fonts.GlobalFontSettings.FontResolver = new MonFontResolver();
            this.nomMission = nomMission;
            this.dateDepart = dateDepart;
            this.dateArrivee = dateArrivee;
            this.nomChef = nomChef;
            this.budgetInitial = budgetInitial;
            this.txtFeuilleRoute = txtFeuilleRoute;
            this.membres = membres;
            this.nbJours = nbJours;
            this.evenements = evenements;
            this.captures = captures;
            this.depenses = depenses;
            this.sommeVersee = sommeVersee;
            this.contactsInformateurs = contacts;
        }

        private void FrmPDF_Load(object sender, EventArgs e)
        {
            try
            {
                pdfViewer1.Document = null;

                if (pdfAffichage != null)
                {
                    pdfAffichage.Dispose();
                    pdfAffichage = null;
                }

                pdfViewer1.Refresh();


                Document documentMigraDoc = new Document();
                Section section = documentMigraDoc.AddSection();

                section.PageSetup.TopMargin = "1.5cm";
                section.PageSetup.BottomMargin = "1.5cm";
                section.PageSetup.LeftMargin = "1.5cm";
                section.PageSetup.RightMargin = "1.5cm";

                Style styleTitre = documentMigraDoc.Styles.AddStyle("MonTitre", "Normal");
                styleTitre.Font.Name = "Kristen ITC";
                styleTitre.Font.Size = 28;
                styleTitre.Font.Bold = true;
                styleTitre.ParagraphFormat.SpaceAfter = "20pt"; // Espace sous le titre

                Style styleSousTitre = documentMigraDoc.Styles.AddStyle("MonSousTitre", "Normal");
                styleSousTitre.Font.Name = "Kristen ITC";
                styleSousTitre.Font.Size = 22;
                styleSousTitre.Font.Bold = true;
                styleSousTitre.ParagraphFormat.SpaceAfter = "10pt"; // Espace sous les sous-titres

                Style stylePetitSousTitre = documentMigraDoc.Styles.AddStyle("MonPetitSousTitre", "Normal");
                stylePetitSousTitre.Font.Name = "Kristen ITC";
                stylePetitSousTitre.Font.Size = 20;
                stylePetitSousTitre.Font.Bold = true;
                stylePetitSousTitre.ParagraphFormat.SpaceAfter = "8pt"; // Espace sous les sous-titres

                Style styleTexte = documentMigraDoc.Styles.AddStyle("MonTexte", "Normal");
                styleTexte.Font.Name = "Kristen ITC";
                styleTexte.Font.Size = 16;
                styleTexte.ParagraphFormat.SpaceAfter = "12pt"; // Espace sous le texte standard


                section.AddParagraph("Rapport de la mission " + nomMission, "MonTitre");
                section.AddParagraph($"Départ le : " + dateDepart, "MonSousTitre");
                section.AddParagraph($"Retour le : " + dateArrivee, "MonSousTitre");
                if(nbJours == 0) 
                {
                    section.AddParagraph($"Durée de la mission : < 1 jours", "MonSousTitre");
                }
                else 
                {
                    section.AddParagraph($"Durée de la mission : " + nbJours + "  jours", "MonSousTitre");
                }
                section.AddParagraph($"Budget initial : " + budgetInitial + "€", "MonSousTitre");

                section.AddParagraph("-------------------------------------------------------------------------------------------", "MonTexte");

                section.AddParagraph("Feuille de route", "MonSousTitre");
                section.AddParagraph(txtFeuilleRoute, "MonTexte");

                section.AddParagraph("-------------------------------------------------------------------------------------------", "MonTexte");

                section.AddParagraph($"Chef de la mission : " + nomChef, "MonSousTitre");
                section.AddParagraph($"Membres de la mission ", "MonSousTitre");
                foreach (string membre in membres)
                {
                    section.AddParagraph("-> " + membre, "MonTexte");
                }

                section.AddParagraph("-------------------------------------------------------------------------------------------", "MonTexte");

                section.AddParagraph($"Journal de bord\n", "MonSousTitre");
                if (evenements.Count == 0)
                {
                    section.AddParagraph("Aucun événement n'a été ajouté à la mission.", "MonTexte");
                }
                else
                {
                    foreach (string evenement in this.evenements)
                    {
                        section.AddParagraph(evenement + "\n\n", "MonTexte");
                    }
                }

                section.AddParagraph("-------------------------------------------------------------------------------------------", "MonTexte");

                int i = 0;

                section.AddParagraph($"Bilan des captures\n", "MonSousTitre");
                if (captures.Count == 0)
                {
                    section.AddParagraph("Aucun objectif de capture n'a été ajouté à la mission.", "MonTexte");
                }
                else
                {
                    foreach (string capture in this.captures)
                    {
                        switch (i) 
                        {
                            case 0:
                                section.AddParagraph("1er objectif de capture : ", "MonPetitSousTitre");
                                i++;
                                break;
                            default:
                                section.AddParagraph($"{i + 1}ème objectif de capture : ", "MonPetitSousTitre");
                                i++;
                                break;
                        }
                        section.AddParagraph(capture + "\n\n", "MonTexte");
                    }
                }

                section.AddParagraph("-------------------------------------------------------------------------------------------", "MonTexte");

                section.AddParagraph($"Gestion du budget", "MonSousTitre");
                section.AddParagraph($"Dépenses effectuées : " + depenses + "€", "MonTexte");
                section.AddParagraph($"Somme versée : " + sommeVersee + "€", "MonTexte");
                section.AddParagraph($"Total dépensé : " + (depenses + sommeVersee) + "€", "MonTexte");
                soldeApresDepense = int.Parse(budgetInitial) - depenses - sommeVersee;
                section.AddParagraph($"Portefeuille après dépenses : " + soldeApresDepense + "€", "MonTexte");

                section.AddParagraph("-------------------------------------------------------------------------------------------", "MonTexte");

                i = 0;

                section.AddParagraph($"Contact avec les informateurs\n\n", "MonSousTitre");
                if (contactsInformateurs.Count == 0)
                {
                    section.AddParagraph("Aucun informateur n'a été ajouté à la mission.", "MonTexte");
                }
                else
                {
                    foreach (string contact in this.contactsInformateurs)
                    {
                        switch (i)
                        {
                            case 0:
                                section.AddParagraph("1er contact : ", "MonPetitSousTitre");
                                i++;
                                break;
                            default:
                                section.AddParagraph($"{i + 1}ème contact : ", "MonPetitSousTitre");
                                i++;
                                break;
                        }
                        section.AddParagraph(contact + "\n\n", "MonTexte");
                    }
                 }

                PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                renderer.Document = documentMigraDoc;
                renderer.RenderDocument();

                string dossierTemp = Path.GetTempPath();
                cheminPdfTemporaire = Path.Combine(dossierTemp, "RapportMission.pdf");

                renderer.PdfDocument.Save(cheminPdfTemporaire);
                renderer.PdfDocument.Close();


                if (pdfAffichage != null)
                {
                    pdfAffichage.Dispose();
                }

                pdfAffichage = PdfiumViewer.PdfDocument.Load(cheminPdfTemporaire);

                pdfViewer1.Document = pdfAffichage;

                pdfViewer1.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (pdfAffichage != null)
            {
                pdfAffichage.Dispose();
            }

            if (!string.IsNullOrEmpty(cheminPdfTemporaire) && File.Exists(cheminPdfTemporaire))
            {
                try { File.Delete(cheminPdfTemporaire); } catch { }
            }

            base.OnFormClosing(e);
        }
    }
}
public class MonFontResolver : PdfSharp.Fonts.IFontResolver
{
    public string DefaultFontName => "Arial";

    public PdfSharp.Fonts.FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        if (familyName.Equals("Kristen ITC", StringComparison.OrdinalIgnoreCase))
        {
            return new PdfSharp.Fonts.FontResolverInfo("KristenITC");
        }

        string fontName = "Arial";
        if (isBold && isItalic) return new PdfSharp.Fonts.FontResolverInfo(fontName, true, true);
        if (isBold) return new PdfSharp.Fonts.FontResolverInfo(fontName, true, false);
        if (isItalic) return new PdfSharp.Fonts.FontResolverInfo(fontName, false, true);

        return new PdfSharp.Fonts.FontResolverInfo(fontName);
    }

    public byte[] GetFont(string faceName)
    {
        if (faceName.StartsWith("KristenITC", StringComparison.OrdinalIgnoreCase))
        {
            string localFontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ITCKRIST.TTF");
            if (File.Exists(localFontPath)) return File.ReadAllBytes(localFontPath);

            string systemFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ITCKRIST.TTF");
            if (File.Exists(systemFontPath)) return File.ReadAllBytes(systemFontPath);
        }

        string fontsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
        string fontPath;

        if (faceName.Contains("Bold") && faceName.Contains("Italic"))
            fontPath = Path.Combine(fontsFolder, "arialbi.ttf");
        else if (faceName.Contains("Bold"))
            fontPath = Path.Combine(fontsFolder, "arialbd.ttf");
        else if (faceName.Contains("Italic"))
            fontPath = Path.Combine(fontsFolder, "ariali.ttf");
        else
            fontPath = Path.Combine(fontsFolder, "arial.ttf");

        if (File.Exists(fontPath)) return File.ReadAllBytes(fontPath);

        return File.ReadAllBytes(Path.Combine(fontsFolder, "arial.ttf"));
    }
}