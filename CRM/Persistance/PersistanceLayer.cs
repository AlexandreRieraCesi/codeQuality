using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Persistance;
	public class PersistanceLayer
	{
		public static void Persist(Object arg, String nomDeLaListe)
		{
			List<Object> listOffres = new List<Object> { };
			List<Object> listProspects = new List<Object> { };
			List<Object> listClients = new List<Object> { };
			List<Object> listFactures = new List<Object> { };

			switch (nomDeLaListe)
			{
				case "offre":
					if (listOffres.Any())
					{
						listOffres.Add(arg);
					}
					break;
				case "prospect":
					if (listProspects.Any())
					{
						listProspects.Add(arg);
					}
					break;
				case "client":
					if (listClients.Any())
					{
						listClients.Add(arg);
					}
					break;
				case "facture":
					if (listFactures.Any())
					{
						listFactures.Add(arg);
					}
					break;
				default:
					break;
			}
		}
	}
