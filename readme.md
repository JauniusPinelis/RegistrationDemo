======================================
Registration Demo
======================================

A rather simple registration app with several requirements (in Lithuanian):
- Registracijos požymiai ir reikšmės užkraunamos iš DB. 
- Registracijos požymių reikšmių koregavimas išsaugomas į DB.
- Registracijos požymių sąrašas kintantis, t.y. turi būti galimybė papildyti sąrašą naujais registracijos požymiais (konfigūruojama/įvedama tiesiai per DB).
- Registracijos požymių reikšmių pasirinkimai (drop-down pasirinkimai) skirtingi priklausomai nuo registracijos požymio (konfigūruojami/įvedami tiesiai per DB).
	
Basically in short the whole metadata of registration structure (questions and dropdowns) have to be in db.

## To run
Requirements: Node.js (for npm and front-end React), Visual Studio with .net core 2.2 for back-end with mssql with local db instance.
1. Run "git clone https://github.com/JauniusPinelis/RegistrationDemo.git" in cmd (or "git pull" to update).
3. Open \Registration\Registration.sln with Visual studio.
3. Modify Registration\Registration.Api -> DefaultConnectionString with your mssql instance.
4. Run "update-database" in nuget console (Registration.Infrastructure). This create db with schema and seed-data.
5. Run the Registration.Api project - you have now web api running. Keep it running.
6. Open Console, change directory to "\ClientApp" and "npm install" in Console. This will install all the front-end required libraries.  
7. In Console run "npm run start" . This runs React Web App which communicates with the Asp.net Core Web Api.

## Notes
Technologies:
- Front-end: React, React-Bootstrap, Sass, Axios
- Back-end: .net-core 2.2 WebApi with default libraries for mapper, dependency injection, entity framework and migrations.

## Notes

1. I realise that a single Razor (With minimal Jquery) + Asp.net MVC project would be a simplier and easier to run solution. 
This could feel "over-engeneered"
However, I wanted this split this application into several parts/projects:
- Registration.Core - The logic of the project (independent of Infrastructure/DB/API). Not much there, only models as the app is quite straightforward.
- Registration.Api - Presentation layer
- Registration.Infrastructure - The code for mappings, EF, db and other infrastucture. This could be split into another project Persistence for just db stuff.
- ClientApp consumes the Web Api
- I prefer to separate Front-end and back-end as it create separation of concerns (as well as use different editors for each side)

2. No Tests :( Lack of time.. I could use EF InmemoryProvider for testing.

## Things to improve
1. Add some testing at least to check RegistrationContext stores objects successfully.
2. Front-end "clear data" functionality currently just reloads data and does uneccessary Api call.
3. Curently it holds data for single registration entity - but it would be quite easy to extend the functionality for multiples registrations.
4. Front-end - could have some kind of check if Back-end is running and display "no server found" if something is wrong.



