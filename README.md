# 🚀 MiniCommercial - Système de Gestion Commerciale

MiniCommercial est une application Full-Stack permettant de gérer les clients, les produits et les commandes. Le projet inclut une génération de factures, une gestion de stock en temps réel et une authentification sécurisée par JWT.

## 🛠️ Technologies Utilisées

- **Back-end :** ASP.NET Core Web API, Entity Framework Core, SQL Server.
- **Front-end :** Angular 16+, Bootstrap 5, Bootstrap Icons.
- **Sécurité :** JSON Web Token (JWT), BCrypt pour le hachage des mots de passe.

---

## 📋 Prérequis

Avant de commencer, assurez-vous d'avoir installé :
- [.NET SDK](https://dotnet.microsoft.com/download) (Version 6, 7 ou 8)
- [Node.js](https://nodejs.org/) (Version 18+)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) ou LocalDB
- [Angular CLI](https://angular.io/cli) (`npm install -g @angular/cli`)

---

## ⚙️ Installation et Lancement

### 1. Back-end (ASP.NET Core)
1. Naviguez vers le dossier du serveur : `cd MiniCommercial.API` (ajustez le nom).
2. Configurez la base de données dans `appsettings.json` :
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MiniCommercialDB;Trusted_Connection=True;"
   }

   Appliquez les migrations pour créer la base de données :

dotnet ef database update
Lancez le serveur :
dotnet run
Le Swagger est accessible sur : https://localhost:7121/swagger (vérifiez votre port).

### 1. Front-end (Angular)

1 Naviguez vers le dossier client : cd MiniCommercialFront.
2 Installez les dépendances :
npm install
3 Lancez l'application :
ng serve --open
L'application sera disponible sur : http://localhost:4200


📸 Captures d'écran
Tableau de Commandes
![alt text](./screenshots/products.png)
Détail de la commande 
![alt text](./screenshots/commande detaille.png) 
Tableau de clients 
 ![alt text](./screenshots/clients.png) 
 Tableau de commandes 
![alt text](./screenshots/commmandes.png)
modification de produit
 ![alt text](./screenshots/modif-products.png)
 creation nouveau client
  ![alt text](./screenshots/NouveauClient.png)
