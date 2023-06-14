namespace gestion_pharmacie

{
	public class GestionMedicament : IGestionMedicament
	{
	
		
			private List<Medicament> inventaire = new List<Medicament>();

			public void AjouterMedicament(Medicament medicament)
			{
				inventaire.Add(medicament);
				Console.WriteLine("Le médicament a été ajouté à l'inventaire.");
			}

			public void VendreMedicament(string code, int quantite)
			{
				Medicament medicament = inventaire.Find(m => m.Code == code);

				if (medicament != null)
				{
					if (medicament.Quantite >= quantite)
					{
						medicament.Quantite -= quantite;
						Console.WriteLine("Vente effectuée avec succès.");
					}
					else
					{
						Console.WriteLine("La quantité demandée n'est pas disponible en stock.");
					}
				}
				else
				{
					Console.WriteLine("Le médicament n'existe pas dans l'inventaire.");
				}
			}

			public void AfficherInventaire()
			{
				Console.WriteLine("Inventaire des médicaments :");
				foreach (Medicament medicament in inventaire)
				{
					Console.WriteLine("Code : " + medicament.Code + ", Nom : " + medicament.Nom + ", Quantité : " + medicament.Quantite);
				}
			}
		}

	}

