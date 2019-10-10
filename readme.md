======================================
Gilded Rose Requirements Specification
======================================

A rather simple registration app with several requirements (in Lithuanian):
	- Registracijos požymiai ir reikšmės užkraunamos iš DB. 
	- Registracijos požymių reikšmių koregavimas išsaugomas į DB.
	- Registracijos požymių sąrašas kintantis, t.y. turi būti galimybė papildyti sąrašą naujais registracijos požymiais (konfigūruojama/įvedama tiesiai per DB).
	- Registracijos požymių reikšmių pasirinkimai (drop-down pasirinkimai) skirtingi priklausomai nuo registracijos požymio (konfigūruojami/įvedami tiesiai per DB).
	
Basically in short the whole metadata of registration structure (questions and dropdowns) have to be in db.

## To run
Requirements: Node.js (for npm and front-end React), Visual Studio with .net core 2.2 for back-end with mssql with local db instance.

1. Open \Registration\Registration.sln with Visual studio.
2. Modify Registration\Registration.Api -> DefaultConnectionString with your mssql instance.
3. Run "update-database" in nuget console (Registration.Infrastructure). This create db with schema and seed-data
4. Run the Visual



