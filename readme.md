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
3. Run "update-database" in nuget console (Registration.Infrastructure). This create db with schema and seed-data.
4. Run the Registration.Api project - you have now web api running.
5. run "npm run start" in \ClientApp. This runs React Web App which communicates with the Asp.net Core Web Api.

## Notes
Technologies:
front-end: React, React-Bootstrap, Sass, Axios
back-end: .net-core 2.2 WebApi with default libraries for mapper, dependency injection, entity framework and migrations.

## Notes

1. I realise that a single Razor (With minimal Jquery) + Asp.net MVC project would be a simplier and easier to run solution/
However, I wanted this split this application into several parts/projects:
- Registration.Core - The logic of the project (independent of Infrastructure/DB/API). Not much there, only models as the app is quite straightforward.
- Registration.Api - Presentation layer
- Registration.Infrastructure - The code for mappings, EF, db and other infrastucture. This could be split into another project Persistence for just db stuff.
- ClientApp consumes the Web Api

2. No Tests :( Lack of time.. I could use EF InmemoryProvider for testing.

## Things to improve




