namespace OHCE.Test
{
    public class UnitTest1
    {

        [Fact(DisplayName = "QUAND on envoie un mot 'laval' ALORS on obtient son miroir")]
        public void TestMiroirToto()
        {
            //QUAND on envoie un mot
            var resultat = new OHCE().Traitement("laval");

            //ALORS on obtient son miroir
            Assert.Contains("laval", resultat);
        }

    }
}