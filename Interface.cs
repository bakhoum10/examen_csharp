namespace gestion_pharmacie
{
	public interface  IGestionMedicament
	{
		
		
			void AjouterMedicament(Medicament medicament);
			void VendreMedicament(string code, int quantite);
			void AfficherInventaire();
	}

	
}
