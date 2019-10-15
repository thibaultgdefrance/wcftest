using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService2.Model;

namespace WcfService2
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        EarthRescueEntities db = new EarthRescueEntities();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string additioner(int value1,int value2)
        {
            float a = value1 + value2;
            return a.ToString();
        }
        public string afficherUtilisateur(int id)
        {
            try
            {
                Joueur joueur = (from j in db.Joueur where j.idJoueur == id select j).First();
                return joueur.pseudoJoueur;
            }
            catch (Exception)
            {

                return "pas de joueur corespondant à cette id";
            }
            
        }
    }
}
