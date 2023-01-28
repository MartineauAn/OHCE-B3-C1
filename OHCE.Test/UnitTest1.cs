using static System.Reflection.Metadata.BlobBuilder;
using System;
using OHCE.Test.utilities;

namespace OHCE.Test
{
    public class UnitTest1
    {

        [Fact(DisplayName = "QUAND on envoie un mot 'laval' ALORS on obtient son miroir")]
        public void TestMiroir()
        {
            //QUAND on envoie un mot
            var resultat = new OHCEBuilder().withLangue(new LangueStub()).build().Traitement("laval");

            //ALORS on obtient son miroir
            Assert.Contains("laval", resultat);
        }

        [Fact(DisplayName = "QUAND on envoie un palindrome ALORS on obtient celui-ci ET 'Bien dit !' est ajouté")]
        public void TestPalindrome()
        {
            const string palindrome = "bob";

            //QUAND on envoie un mot
            var resultat = new OHCEBuilder().withLangue(new LangueStub()).build().Traitement(palindrome);

            //ALORS on obtient celui-ci
            Assert.Contains(palindrome, resultat);

            var indexOfPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endOfPalindrome = indexOfPalindrome + palindrome.Length;
            resultat = resultat[endOfPalindrome..];

            //ET 'Bien dit !' est ajouté
            Assert.Contains("Bien dit !", resultat);
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS « Bonjour » est envoyé avant toute réponse")]
        public void TestBonjour()
        {
            //QUAND on saisit une chaîne
            var resultat = new OHCEBuilder().withLangue(new LangueStub()).build().Traitement("test de chaine");

            //ALORS « Bonjour » est envoyé avant toute réponse
            Assert.StartsWith("Bonjour", resultat);
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS « Au revoir » est envoyé en dernier")]
        public void TestAuRevoir()
        {
            //QUAND on saisit une chaîne
            var resultat = new OHCEBuilder().withLangue(new LangueStub()).build().Traitement("test de chaine");

            //ALORS « au revoir » est envoyé avant toute réponse
            Assert.EndsWith("Au revoir", resultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on entre un palindrome ALORS il est renvoyé ET le < bienDit > de cette langue est envoyé")]
        [ClassData(typeof(PalindromeClassData))]
        public void TestPalindromeLangue(ILangue langue, string palindrome)
        {

            //QUAND on envoie un mot
            var resultat = new OHCEBuilder().withLangue(langue).build().Traitement(palindrome);

            //ALORS on obtient celui-ci
            Assert.Contains(palindrome, resultat);

            var indexOfPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endOfPalindrome = indexOfPalindrome + palindrome.Length;
            resultat = resultat[endOfPalindrome..];

            //ET 'Bien dit !' est ajouté
            Assert.Contains(langue.BienDit, resultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une chaîne ALORS <bonjour> de cette langue est envoyé avant tout")]
        [ClassData(typeof(SalutationsClassData))]
        public void TestBonjourLangue(ILangue langue)
        {

            //QUAND on saisit une chaîne
            var resultat = new OHCEBuilder().withLangue(langue).build().Traitement("test de chaine");

            //ALORS <bonjour> de cette langue est envoyé avant tout
            Assert.StartsWith(langue.Bonjour, resultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une chaîne ALORS <auRevoir> dans cette langue est envoyé en dernier")]
        [ClassData(typeof(SalutationsClassData))]
        public void TestAuRevoirLangue(ILangue langue)
        {
            //QUAND on saisit une chaîne
            var resultat = new OHCEBuilder().withLangue(langue).build().Traitement("test de chaine");

            //ALORS « au revoir » est envoyé avant toute réponse
            Assert.EndsWith(langue.AuRevoir, resultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <salutation> de cette langue à cette période est envoyé avant tout")]
        [ClassData(typeof(SalutationsPeriodeClassData))]
        public void TestBonjourLanguePeriode(ILangue langue, string periode)
        {
            //QUAND on saisit une chaîne
            var resultat = new OHCEBuilder().withLangue(langue).withPeriode(periode).build().Traitement("test de chaine");

            //ALORS <bonjour> de cette langue à cette période est envoyé avant tout
            Assert.StartsWith(langue.Bonjour + periode, resultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <au revoir> de cette langue à cette période est envoyé avant tout")]
        [ClassData(typeof(SalutationsPeriodeClassData))]
        public void TestAuRevoirLanguePeriode(ILangue langue, string periode)
        {
            //QUAND on saisit une chaîne
            var resultat = new OHCEBuilder().withLangue(langue).withPeriode(periode).build().Traitement("test de chaine");

            //ALORS <au revoir> de cette langue à cette période est envoyé avant tout
            Assert.EndsWith(langue.AuRevoir + periode, resultat);
        }

    }
}