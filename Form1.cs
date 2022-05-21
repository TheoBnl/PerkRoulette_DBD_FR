using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perk_roulette_NET6._0
{
    public partial class Form1 : Form
    {
        private string[] perkKiller = new string[] { "Agitation", "Amasseur", "Appel de la Mer", "Aucune Issue", "Boucher Sadique", "Bricolo", "Chili et Barbecue", "Claustrophobie",
        "Coulrophobie", "Coup de Grâce", "Coup du Pendu", "Cran dément", "Crochet Flagellateur: Don de souffrance", "Corchet Flagellateur: Flots de Rage", "Crochet Flagellateur: Echo de Douleur",
        "Discordance", "Dispositif de l'Homme Mort", "Déboussoler", "Ennemi Juré", "Espions de l'Ombre", "Fais ton Choix", "Fascination", "Force Brute", "Frissons Palpitants", "Fureur de l'Esprit",
        "Garder le Meilleur pour la Fin", "Gardien de Sang", "Hystérie", "Impasse", "Implacable", "Inquiétant", "Insidieux", "Instinct Territorial", "Intensité Ardente", "Intervention Impure",
        "Je vous Ecoute", "Jouer avec la Nourriture", "K.O", "Le Tour est joué", "Lien Mortel", "Limier", "Lumière Mourante", "Murmure Amer", "Murmures", "Opprssion", "Peur Contagieuse",
        "Piste de Souffrance", "Pisteur", "Poing de Fer", "Poursuite Furtive", "Poursuivant Meurtrier", "Prise du Dragon", "Prédateur", "Prédation", "Présence Perturbante", "Présence Ecrasante",
        "Pénitence Forcée", "Rancoeur", "Rejeton de l'Obscurité", "Rejeton de Lumière", "Réparateur", "Sanctuaire Monstrueux", "Secousse", "Semeur de Peur", "Sombre Dévotion", "Sombre Etreinte",
        "Hex: Berceuse de la Chasseuse", "Hex: Châtiment", "Hex: Contrôle des Foules", "Hex: Euphorie de la Chasse", "Hex: Faveur de Sang", "Hex: Immortel", "Hex: Jouet", "Hex: Le Troisième Sceau",
        "Hex: Mangeur d'Espoir", "Hex: Personne n'échappe à la Mort", "Hex: Repentir", "Hex: Ruine", "Hex: Terrain Hanté", "Souviens-Toi de Moi", "Stridor", "Surcharge", "Surveillance", "Surveillance et Maltraitance",
        "Tactique de Zanshin", "Tempête Impitoyable", "Tenace", "Thanatophobie", "Trépas de Franklin", "Vierge de Fer", "Vocation de l'Infirmière", "Echo Sanguin", "Eruption"};

        private string[] perkSurvivor = new string[] { "Abandonné", "Accrochez-Vous", "Adrénaline", "Affinités", "Alliance Refoulée", "Assurance", "Atout de la Manche", "Atterrissage Equilibré",
        "Augmenter la Mise", "Auto-Traitement", "Autodidacte", "Bras de Fer", "Bénédiction: Cercle de Soins", "Bénédiction: Exponentiel", "Bénédiction: Marche de l'Ombre", "Bénédiction: Théorie Ténébreuse",
        "Ce n'est pas en Train d'Arriver", "Clairvoyance", "Concentration Intérieure", "Confidentiel", "Connaissance en Botanique", "Connexion Empathique", "Conscience Situationnelle", "Conscience de Soi",
        "Conseils Parentaux", "Contre-Force", "Conçu pour Durer", "Coup Décisif", "Coupe de Chance", "Course Effrénée", "Danse Avec Moi", "De Front", "Debout !", "Dernier Survivant", "Distorsion",
        "Diversion", "Dead Hard", "Débrouillardise", "Déjà-Vu", "Détermination du Bleu", "Effondrement", "Effusion", "Empathie", "En Planque", "Espoir", "Esprit Calme", "Estimation", "Excès de Zèle",
        "Montrez ce que vous savez Faire", "Force de Caractère", "Frisson", "Gardien", "Grenade Aveuglante", "Guérison Interne", "Indéfectible", "Instinct de Pillard", "Instinct de Survie",
        "Intuition de l'Inspecteur", "Le Coeur sur la Main", "Leurre", "Libération", "Lien", "Manifeste Résiduel", "Meneur", "Mesure de Correction", "Mesures Désespérées", "Mine Explosive", 
        "Nous Vivrons Eternellement", "Nous Y Arriverons", "Objet d'Obsession", "On n'Abandonne Personne", "Pacte de Sang", "Par Tous les Moyens", "Parenté", "Parfaite Occasion", "Pas Envie", 
        "Petit Gibier", "Pharmacie", "Poids Plume", "Pour le Peuple", "Protection de l'Ame", "Prémonition", "Rapide et Silencieux", "Renaissance", "Renouvellement", "Résistance", "Saboteur", 
        "Sentiment Obscure", "Serrer les Dents", "Solidarité", "Souple", "Succès Ecrasant", "Suivi des Soins", "Supercherie", "Surmonter", "Sursis", "Technicien", "Ténacité", "Veillée",
        "Viande Glissante", "Vigilant", "Visionnaire", "Voie Rapide", "Volonté de Fer", "A la Revoyure", "Evasion", "Evasion Urbaine"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tueurButton_Click(object sender, EventArgs e)
        {
            Random alea = new Random();

            //tirage des 4 perks avec possibilité de doublon

            int perkNumber1 = alea.Next(perkKiller.Length);
            string perkText1 = perkKiller[perkNumber1];


            int perkNumber2 = alea.Next(perkKiller.Length);
            string perkText2 = perkKiller[perkNumber2];
            
            int perkNumber3 = alea.Next(perkKiller.Length);
            string perkText3 = perkKiller[perkNumber3];

            int perkNumber4 = alea.Next(perkKiller.Length);
            string perkText4 = perkKiller[perkNumber4];

            //while pour éviter de tomber plusieurs fois sur la même perks

            while(perkNumber2 == perkNumber1)
            {
                perkNumber2 = alea.Next(perkKiller.Length);
                perkText2 = perkKiller[perkNumber2];
            }

            while(perkNumber3 == perkNumber1 || perkNumber3 == perkNumber2)
            {
                perkNumber3 = alea.Next(perkKiller.Length);
                perkText3 = perkKiller[perkNumber3];
            }

            while(perkNumber4 == perkNumber1 || perkNumber4 == perkNumber2 || perkNumber4 == perkNumber3)
            {
                perkNumber4 = alea.Next(perkKiller.Length);
                perkText4 = perkKiller[perkNumber4];
            }

            //Affichage des perks

            perk1.Text = "" + perkText1;
            perk2.Text = "" + perkText2;
            perk3.Text = "" + perkText3;
            perk4.Text = "" + perkText4;
        }

        private void survivantButton_Click(object sender, EventArgs e)
        {
            Random alea = new Random();

            //tirage des 4 perks avec possibilité de doublon

            int perkNumber1 = alea.Next(perkSurvivor.Length);
            string perkText1 = perkSurvivor[perkNumber1];

            int perkNumber2 = alea.Next(perkSurvivor.Length);
            string perkText2 = perkSurvivor[perkNumber2];

            int perkNumber3 = alea.Next(perkSurvivor.Length);
            string perkText3 = perkSurvivor[perkNumber3];

            int perkNumber4 = alea.Next(perkSurvivor.Length);
            string perkText4 = perkSurvivor[perkNumber4];

            //while pour éviter de tomber plusieurs fois sur la même perks

            while (perkNumber2 == perkNumber1)
            {
                perkNumber2 = alea.Next(perkSurvivor.Length);
                perkText2 = perkSurvivor[perkNumber2];
            }

            while (perkNumber3 == perkNumber1 || perkNumber3 == perkNumber2)
            {
                perkNumber3 = alea.Next(perkSurvivor.Length);
                perkText3 = perkSurvivor[perkNumber3];
            }

            while (perkNumber4 == perkNumber1 || perkNumber4 == perkNumber2 || perkNumber4 == perkNumber3)
            {
                perkNumber4 = alea.Next(perkSurvivor.Length);
                perkText4 = perkSurvivor[perkNumber4];
            }

            //Affichage des perks

            perk1.Text = "" + perkText1;
            perk2.Text = "" + perkText2;
            perk3.Text = "" + perkText3;
            perk4.Text = "" + perkText4;

        }
    }
}
