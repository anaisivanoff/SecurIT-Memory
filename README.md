# Projet-SecurIT-Memory

Jeu de Memory développé en C# / WinForms sur le thème de la cybersécurité, avec plusieurs modes de jeu, un fond animé façon terminal, une interface personnalisée et une architecture orientée objet.

# Objectifs d’apprentissage

Ce projet a été réalisé dans le cadre d’un exercice de développement logiciel en C# et WinForms.
Il m’a permis de :

. Concevoir une application graphique complète en WinForms.

. Structurer un projet en programmation orientée objet (classes, modèles, logique métier).

. Gérer des événements, des timers, et des animations graphiques.

. Implémenter plusieurs modes de jeu (chronomètre, hardcore, mémoire inversée).

. Créer une interface personnalisée avec un thème cybersécurité.

. Dessiner un fond animé via l’événement Paint (effet terminal).

. Manipuler dynamiquement des grilles de cartes selon la difficulté.

. Améliorer l’expérience utilisateur avec un menu, des options, et un système de navigation.

# Stack technique

Langage :

. C# (.NET)

Framework :

. WinForms

Concepts utilisés :

. Programmation orientée objet

. Timers (System.Windows.Forms.Timer)

. Gestion d’événements

. Dessin graphique (PaintEventArgs)

. Génération dynamique d’UI

. Architecture simple mais propre (Models / Forms)

IDE :

. Visual Studio

# Fonctionnalités du jeu

Modes de difficulté
- Facile (4×4)

- Moyen (6×6)

- Difficile (8×8)

 Modes de jeu
- Mémoire inversée : les cartes se retournent automatiquement

- Mode chronomètre : le temps est compté

- Mode hardcore : erreurs limitées

# Structure du projet

/ProjetSecurITMemory
│
├── Form1.cs                → Menu principal + fond animé
├── FormOptions.cs          → Choix des modes et difficultés
├── FormGame.cs             → Logique du jeu + affichage des cartes
│
├── Models/
│   ├── GameOptions.cs
│   ├── DifficultyLevel.cs
│   └── autres classes...
│
└── Assets/
    └── Images des cartes
