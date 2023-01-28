namespace OHCE.Test
{
    public class UnitTest1
    {

        [Fact(DisplayName = "QUAND on envoie un mot 'laval' ALORS on obtient son miroir")]
        public void TestMiroir()
        {
            //QUAND on envoie un mot
            var resultat = new OHCE().Traitement("laval");

            //ALORS on obtient son miroir
            Assert.Contains("laval", resultat);
        }

        [Fact(DisplayName = "QUAND on envoie un palindrome ALORS on obtient celui-ci ET 'Bien dit !' est ajouté")]
        public void TestPalindrome()
        {
            const string palindrome = "bob";

            //QUAND on envoie un mot
            var resultat = new OHCE().Traitement(palindrome);

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
            var resultat = new OHCE().Traitement("test de chaine");

            //ALORS « Bonjour » est envoyé avant toute réponse
            Assert.StartsWith("Bonjour", resultat);
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS « Au revoir » est envoyé en dernier")]
        public void TestAuRevoir()
        {
            //QUAND on saisit une chaîne
            var resultat = new OHCE().Traitement("test de chaine");

            //ALORS « Bonjour » est envoyé avant toute réponse
            Assert.EndsWith("Au revoir", resultat);
        }

    }
}