using gestion_pharmacie;

class program
{

	static void Main(string[] args)
	{
		IGestionMedicament gestionMedicament = new GestionMedicament();

		bool quitter = false;

		while (!quitter)
		{
			Console.WriteLine("\n--- Gestion de pharmacie ---");
			Console.WriteLine("1. Ajouter un m�dicament");
			Console.WriteLine("2. Vendre un m�dicament");
			Console.WriteLine("3. Afficher l'inventaire");
			Console.WriteLine("4. Quitter");

			Console.Write("Choisissez une option : ");
			string choix = Console.ReadLine();

			switch (choix)
			{
				case "1":
					Console.Write("Code du m�dicament : ");
					string code = Console.ReadLine();
					Console.Write("Nom du m�dicament : ");
					string nom = Console.ReadLine();
					Console.Write("Quantit� du m�dicament : ");
					int quantite = int.Parse(Console.ReadLine());

					Medicament medicament = new Medicament
					{
						Code = code,
						Nom = nom,
						Quantite = quantite
					};

					gestionMedicament.AjouterMedicament(medicament);
					break;
				case "2":
					Console.Write("Code du m�dicament � vendre : ");
					string codeVente = Console.ReadLine();
					Console.Write("Quantit� � vendre : ");
					int quantiteVente = int.Parse(Console.ReadLine());
					gestionMedicament.VendreMedicament(codeVente, quantiteVente);
					break;
				case "3":
					gestionMedicament.AfficherInventaire();
					break;
				case "4":
					quitter = true;
					break;
				default:
					Console.WriteLine("Option invalide.");
					break;
			}
		}
		}
	}
