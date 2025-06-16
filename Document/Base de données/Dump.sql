CREATE TABLE Etat(
   Id_Etat INT AUTO_INCREMENT,
   ETA_Libelle VARCHAR(50) ,
   PRIMARY KEY(Id_Etat)
);

CREATE TABLE Recette(
   Id_Recette INT AUTO_INCREMENT,
   REC_Nom VARCHAR(50)  NOT NULL,
   REC_DateHeureCreation DATETIME NOT NULL,
   PRIMARY KEY(Id_Recette),
   UNIQUE(REC_Nom)
);

CREATE TABLE Lot(
   Id_Lot INT AUTO_INCREMENT,
   LOT_Nom VARCHAR(50)  NOT NULL,
   LOT_Quantite INT NOT NULL,
   LOT_DateHeureCreation DATETIME NOT NULL,
   Id_Etat INT NOT NULL,
   Id_Recette INT NOT NULL,
   PRIMARY KEY(Id_Lot),
   UNIQUE(LOT_Nom),
   FOREIGN KEY(Id_Etat) REFERENCES Etat(Id_Etat),
   FOREIGN KEY(Id_Recette) REFERENCES Recette(Id_Recette)
);

CREATE TABLE Evenement(
   Id_Evenement INT AUTO_INCREMENT,
   EVE_Message VARCHAR(50)  NOT NULL,
   EVE_DateHeure DATETIME,
   Id_Lot INT NOT NULL,
   PRIMARY KEY(Id_Evenement),
   FOREIGN KEY(Id_Lot) REFERENCES Lot(Id_Lot)
);

CREATE TABLE Operation(
   Id_Operation INT AUTO_INCREMENT,
   OPE_Nom VARCHAR(50) ,
   OPE_Numero INT,
   OPE_PositionMoteur INT,
   OPE_TempsAttente INT,
   OPE_CycleVerin BOOLEAN,
   OPE_Quittance BOOLEAN,
   OPE_SensMoteur BOOLEAN,
   Id_Recette INT NOT NULL,
   PRIMARY KEY(Id_Operation),
   FOREIGN KEY(Id_Recette) REFERENCES Recette(Id_Recette)
);


INSERT INTO Etat (Id_Etat, ETA_Libelle) VALUES (1, 'En attente');
INSERT INTO Etat (Id_Etat, ETA_Libelle) VALUES (2, 'En cours');
INSERT INTO Etat (Id_Etat, ETA_Libelle) VALUES (3, 'Produit');
INSERT INTO Etat (Id_Etat, ETA_Libelle) VALUES (4, 'Erreur');

INSERT INTO Recette (Id_Recette, REC_Nom, REC_DateHeureCreation) VALUES (1, 'AM 465', '2025-04-25 08:00:00');
INSERT INTO Recette (Id_Recette, REC_Nom, REC_DateHeureCreation) VALUES (2, 'BP 320', '2025-04-25 09:00:00');
INSERT INTO Recette (Id_Recette, REC_Nom, REC_DateHeureCreation) VALUES (3, 'CT 198', '2025-04-25 10:00:00');
INSERT INTO Recette (Id_Recette, REC_Nom, REC_DateHeureCreation) VALUES (4, 'DN 754', '2025-04-25 11:00:00');

INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (1, '445-AM 465-25.04.25', 445, '2025-04-25 09:00:00', 1, 1);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (2, '229-BP 320-25.04.26', 229, '2025-04-26 09:00:00', 2, 2);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (3, '343-CT 198-25.04.27', 343, '2025-04-27 09:00:00', 3, 3);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (4, '389-DN 754-25.04.28', 389, '2025-04-28 09:00:00', 4, 4);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (5, '166-AM 465-25.04.29', 166, '2025-04-29 09:00:00', 1, 1);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (6, '307-BP 320-25.04.30', 307, '2025-04-30 09:00:00', 2, 2);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (7, '327-CT 198-25.05.01', 327, '2025-05-01 09:00:00', 3, 3);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (8, '465-DN 754-25.05.02', 465, '2025-05-02 09:00:00', 4, 4);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (9, '249-AM 465-25.05.03', 249, '2025-05-03 09:00:00', 1, 1);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (10, '414-BP 320-25.05.04', 414, '2025-05-04 09:00:00', 2, 2);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (11, '261-CT 198-25.05.05', 261, '2025-05-05 09:00:00', 3, 3);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (12, '113-DN 754-25.05.06', 113, '2025-05-06 09:00:00', 4, 4);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (13, '418-AM 465-25.05.07', 418, '2025-05-07 09:00:00', 1, 1);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (14, '469-BP 320-25.05.08', 469, '2025-05-08 09:00:00', 2, 2);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (15, '236-CT 198-25.05.09', 236, '2025-05-09 09:00:00', 3, 3);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (16, '386-DN 754-25.05.10', 386, '2025-05-10 09:00:00', 4, 4);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (17, '218-AM 465-25.05.11', 218, '2025-05-11 09:00:00', 1, 1);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (18, '193-BP 320-25.05.12', 193, '2025-05-12 09:00:00', 2, 2);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (19, '325-CT 198-25.05.13', 325, '2025-05-13 09:00:00', 3, 3);
INSERT INTO Lot (Id_Lot, LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) VALUES (20, '363-DN 754-25.05.14', 363, '2025-05-14 09:00:00', 4, 4);

INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (1, 'Evenement 1 du lot 1', '2025-04-26 08:00:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (2, 'Evenement 2 du lot 1', '2025-04-26 08:05:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (3, 'Evenement 3 du lot 1', '2025-04-26 08:10:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (4, 'Evenement 4 du lot 1', '2025-04-26 08:15:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (5, 'Evenement 5 du lot 1', '2025-04-26 08:20:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (6, 'Evenement 6 du lot 1', '2025-04-26 08:25:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (7, 'Evenement 7 du lot 1', '2025-04-26 08:30:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (8, 'Evenement 8 du lot 1', '2025-04-26 08:35:00', 1);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (9, 'Evenement 1 du lot 2', '2025-04-27 08:00:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (10, 'Evenement 2 du lot 2', '2025-04-27 08:05:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (11, 'Evenement 3 du lot 2', '2025-04-27 08:10:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (12, 'Evenement 4 du lot 2', '2025-04-27 08:15:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (13, 'Evenement 5 du lot 2', '2025-04-27 08:20:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (14, 'Evenement 6 du lot 2', '2025-04-27 08:25:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (15, 'Evenement 7 du lot 2', '2025-04-27 08:30:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (16, 'Evenement 8 du lot 2', '2025-04-27 08:35:00', 2);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (17, 'Evenement 1 du lot 3', '2025-04-28 08:00:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (18, 'Evenement 2 du lot 3', '2025-04-28 08:05:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (19, 'Evenement 3 du lot 3', '2025-04-28 08:10:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (20, 'Evenement 4 du lot 3', '2025-04-28 08:15:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (21, 'Evenement 5 du lot 3', '2025-04-28 08:20:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (22, 'Evenement 6 du lot 3', '2025-04-28 08:25:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (23, 'Evenement 7 du lot 3', '2025-04-28 08:30:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (24, 'Evenement 8 du lot 3', '2025-04-28 08:35:00', 3);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (25, 'Evenement 1 du lot 4', '2025-04-29 08:00:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (26, 'Evenement 2 du lot 4', '2025-04-29 08:05:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (27, 'Evenement 3 du lot 4', '2025-04-29 08:10:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (28, 'Evenement 4 du lot 4', '2025-04-29 08:15:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (29, 'Evenement 5 du lot 4', '2025-04-29 08:20:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (30, 'Evenement 6 du lot 4', '2025-04-29 08:25:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (31, 'Evenement 7 du lot 4', '2025-04-29 08:30:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (32, 'Evenement 8 du lot 4', '2025-04-29 08:35:00', 4);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (33, 'Evenement 1 du lot 5', '2025-04-30 08:00:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (34, 'Evenement 2 du lot 5', '2025-04-30 08:05:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (35, 'Evenement 3 du lot 5', '2025-04-30 08:10:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (36, 'Evenement 4 du lot 5', '2025-04-30 08:15:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (37, 'Evenement 5 du lot 5', '2025-04-30 08:20:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (38, 'Evenement 6 du lot 5', '2025-04-30 08:25:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (39, 'Evenement 7 du lot 5', '2025-04-30 08:30:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (40, 'Evenement 8 du lot 5', '2025-04-30 08:35:00', 5);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (41, 'Evenement 1 du lot 6', '2025-05-01 08:00:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (42, 'Evenement 2 du lot 6', '2025-05-01 08:05:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (43, 'Evenement 3 du lot 6', '2025-05-01 08:10:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (44, 'Evenement 4 du lot 6', '2025-05-01 08:15:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (45, 'Evenement 5 du lot 6', '2025-05-01 08:20:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (46, 'Evenement 6 du lot 6', '2025-05-01 08:25:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (47, 'Evenement 7 du lot 6', '2025-05-01 08:30:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (48, 'Evenement 8 du lot 6', '2025-05-01 08:35:00', 6);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (49, 'Evenement 1 du lot 7', '2025-05-02 08:00:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (50, 'Evenement 2 du lot 7', '2025-05-02 08:05:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (51, 'Evenement 3 du lot 7', '2025-05-02 08:10:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (52, 'Evenement 4 du lot 7', '2025-05-02 08:15:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (53, 'Evenement 5 du lot 7', '2025-05-02 08:20:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (54, 'Evenement 6 du lot 7', '2025-05-02 08:25:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (55, 'Evenement 7 du lot 7', '2025-05-02 08:30:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (56, 'Evenement 8 du lot 7', '2025-05-02 08:35:00', 7);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (57, 'Evenement 1 du lot 8', '2025-05-03 08:00:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (58, 'Evenement 2 du lot 8', '2025-05-03 08:05:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (59, 'Evenement 3 du lot 8', '2025-05-03 08:10:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (60, 'Evenement 4 du lot 8', '2025-05-03 08:15:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (61, 'Evenement 5 du lot 8', '2025-05-03 08:20:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (62, 'Evenement 6 du lot 8', '2025-05-03 08:25:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (63, 'Evenement 7 du lot 8', '2025-05-03 08:30:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (64, 'Evenement 8 du lot 8', '2025-05-03 08:35:00', 8);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (65, 'Evenement 1 du lot 9', '2025-05-04 08:00:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (66, 'Evenement 2 du lot 9', '2025-05-04 08:05:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (67, 'Evenement 3 du lot 9', '2025-05-04 08:10:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (68, 'Evenement 4 du lot 9', '2025-05-04 08:15:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (69, 'Evenement 5 du lot 9', '2025-05-04 08:20:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (70, 'Evenement 6 du lot 9', '2025-05-04 08:25:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (71, 'Evenement 7 du lot 9', '2025-05-04 08:30:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (72, 'Evenement 8 du lot 9', '2025-05-04 08:35:00', 9);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (73, 'Evenement 1 du lot 10', '2025-05-05 08:00:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (74, 'Evenement 2 du lot 10', '2025-05-05 08:05:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (75, 'Evenement 3 du lot 10', '2025-05-05 08:10:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (76, 'Evenement 4 du lot 10', '2025-05-05 08:15:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (77, 'Evenement 5 du lot 10', '2025-05-05 08:20:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (78, 'Evenement 6 du lot 10', '2025-05-05 08:25:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (79, 'Evenement 7 du lot 10', '2025-05-05 08:30:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (80, 'Evenement 8 du lot 10', '2025-05-05 08:35:00', 10);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (81, 'Evenement 1 du lot 11', '2025-05-06 08:00:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (82, 'Evenement 2 du lot 11', '2025-05-06 08:05:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (83, 'Evenement 3 du lot 11', '2025-05-06 08:10:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (84, 'Evenement 4 du lot 11', '2025-05-06 08:15:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (85, 'Evenement 5 du lot 11', '2025-05-06 08:20:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (86, 'Evenement 6 du lot 11', '2025-05-06 08:25:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (87, 'Evenement 7 du lot 11', '2025-05-06 08:30:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (88, 'Evenement 8 du lot 11', '2025-05-06 08:35:00', 11);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (89, 'Evenement 1 du lot 12', '2025-05-07 08:00:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (90, 'Evenement 2 du lot 12', '2025-05-07 08:05:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (91, 'Evenement 3 du lot 12', '2025-05-07 08:10:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (92, 'Evenement 4 du lot 12', '2025-05-07 08:15:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (93, 'Evenement 5 du lot 12', '2025-05-07 08:20:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (94, 'Evenement 6 du lot 12', '2025-05-07 08:25:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (95, 'Evenement 7 du lot 12', '2025-05-07 08:30:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (96, 'Evenement 8 du lot 12', '2025-05-07 08:35:00', 12);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (97, 'Evenement 1 du lot 13', '2025-05-08 08:00:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (98, 'Evenement 2 du lot 13', '2025-05-08 08:05:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (99, 'Evenement 3 du lot 13', '2025-05-08 08:10:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (100, 'Evenement 4 du lot 13', '2025-05-08 08:15:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (101, 'Evenement 5 du lot 13', '2025-05-08 08:20:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (102, 'Evenement 6 du lot 13', '2025-05-08 08:25:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (103, 'Evenement 7 du lot 13', '2025-05-08 08:30:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (104, 'Evenement 8 du lot 13', '2025-05-08 08:35:00', 13);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (105, 'Evenement 1 du lot 14', '2025-05-09 08:00:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (106, 'Evenement 2 du lot 14', '2025-05-09 08:05:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (107, 'Evenement 3 du lot 14', '2025-05-09 08:10:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (108, 'Evenement 4 du lot 14', '2025-05-09 08:15:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (109, 'Evenement 5 du lot 14', '2025-05-09 08:20:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (110, 'Evenement 6 du lot 14', '2025-05-09 08:25:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (111, 'Evenement 7 du lot 14', '2025-05-09 08:30:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (112, 'Evenement 8 du lot 14', '2025-05-09 08:35:00', 14);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (113, 'Evenement 1 du lot 15', '2025-05-10 08:00:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (114, 'Evenement 2 du lot 15', '2025-05-10 08:05:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (115, 'Evenement 3 du lot 15', '2025-05-10 08:10:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (116, 'Evenement 4 du lot 15', '2025-05-10 08:15:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (117, 'Evenement 5 du lot 15', '2025-05-10 08:20:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (118, 'Evenement 6 du lot 15', '2025-05-10 08:25:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (119, 'Evenement 7 du lot 15', '2025-05-10 08:30:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (120, 'Evenement 8 du lot 15', '2025-05-10 08:35:00', 15);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (121, 'Evenement 1 du lot 16', '2025-05-11 08:00:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (122, 'Evenement 2 du lot 16', '2025-05-11 08:05:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (123, 'Evenement 3 du lot 16', '2025-05-11 08:10:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (124, 'Evenement 4 du lot 16', '2025-05-11 08:15:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (125, 'Evenement 5 du lot 16', '2025-05-11 08:20:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (126, 'Evenement 6 du lot 16', '2025-05-11 08:25:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (127, 'Evenement 7 du lot 16', '2025-05-11 08:30:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (128, 'Evenement 8 du lot 16', '2025-05-11 08:35:00', 16);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (129, 'Evenement 1 du lot 17', '2025-05-12 08:00:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (130, 'Evenement 2 du lot 17', '2025-05-12 08:05:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (131, 'Evenement 3 du lot 17', '2025-05-12 08:10:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (132, 'Evenement 4 du lot 17', '2025-05-12 08:15:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (133, 'Evenement 5 du lot 17', '2025-05-12 08:20:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (134, 'Evenement 6 du lot 17', '2025-05-12 08:25:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (135, 'Evenement 7 du lot 17', '2025-05-12 08:30:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (136, 'Evenement 8 du lot 17', '2025-05-12 08:35:00', 17);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (137, 'Evenement 1 du lot 18', '2025-05-13 08:00:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (138, 'Evenement 2 du lot 18', '2025-05-13 08:05:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (139, 'Evenement 3 du lot 18', '2025-05-13 08:10:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (140, 'Evenement 4 du lot 18', '2025-05-13 08:15:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (141, 'Evenement 5 du lot 18', '2025-05-13 08:20:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (142, 'Evenement 6 du lot 18', '2025-05-13 08:25:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (143, 'Evenement 7 du lot 18', '2025-05-13 08:30:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (144, 'Evenement 8 du lot 18', '2025-05-13 08:35:00', 18);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (145, 'Evenement 1 du lot 19', '2025-05-14 08:00:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (146, 'Evenement 2 du lot 19', '2025-05-14 08:05:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (147, 'Evenement 3 du lot 19', '2025-05-14 08:10:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (148, 'Evenement 4 du lot 19', '2025-05-14 08:15:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (149, 'Evenement 5 du lot 19', '2025-05-14 08:20:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (150, 'Evenement 6 du lot 19', '2025-05-14 08:25:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (151, 'Evenement 7 du lot 19', '2025-05-14 08:30:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (152, 'Evenement 8 du lot 19', '2025-05-14 08:35:00', 19);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (153, 'Evenement 1 du lot 20', '2025-05-15 08:00:00', 20);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (154, 'Evenement 2 du lot 20', '2025-05-15 08:05:00', 20);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (155, 'Evenement 3 du lot 20', '2025-05-15 08:10:00', 20);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (156, 'Evenement 4 du lot 20', '2025-05-15 08:15:00', 20);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (157, 'Evenement 5 du lot 20', '2025-05-15 08:20:00', 20);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (158, 'Evenement 6 du lot 20', '2025-05-15 08:25:00', 20);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (159, 'Evenement 7 du lot 20', '2025-05-15 08:30:00', 20);
INSERT INTO Evenement (Id_Evenement, EVE_Message, EVE_DateHeure, Id_Lot) VALUES (160, 'Evenement 8 du lot 20', '2025-05-15 08:35:00', 20);

INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (1, 'Operation 1 de recette 1', 1, 1, 13, 1, 1, 1, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (2, 'Operation 2 de recette 1', 2, 4, 17, 1, 1, 1, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (3, 'Operation 3 de recette 1', 3, 3, 8, 1, 0, 0, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (4, 'Operation 4 de recette 1', 4, 1, 19, 0, 0, 0, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (5, 'Operation 5 de recette 1', 5, 4, 6, 1, 0, 0, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (6, 'Operation 6 de recette 1', 6, 1, 10, 1, 1, 0, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (7, 'Operation 7 de recette 1', 7, 3, 6, 0, 0, 0, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (8, 'Operation 8 de recette 1', 8, 4, 11, 1, 1, 1, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (9, 'Operation 9 de recette 1', 9, 4, 6, 1, 1, 0, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (10, 'Operation 10 de recette 1', 10, 5, 19, 1, 1, 1, 1);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (11, 'Operation 1 de recette 2', 1, 1, 19, 1, 0, 0, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (12, 'Operation 2 de recette 2', 2, 1, 17, 0, 0, 0, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (13, 'Operation 3 de recette 2', 3, 5, 17, 1, 0, 1, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (14, 'Operation 4 de recette 2', 4, 2, 18, 1, 1, 1, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (15, 'Operation 5 de recette 2', 5, 1, 11, 0, 1, 1, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (16, 'Operation 6 de recette 2', 6, 3, 19, 1, 0, 1, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (17, 'Operation 7 de recette 2', 7, 1, 10, 0, 1, 1, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (18, 'Operation 8 de recette 2', 8, 3, 11, 0, 1, 0, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (19, 'Operation 9 de recette 2', 9, 3, 18, 0, 0, 1, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (20, 'Operation 10 de recette 2', 10, 5, 12, 1, 1, 0, 2);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (21, 'Operation 1 de recette 3', 1, 5, 20, 1, 1, 1, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (22, 'Operation 2 de recette 3', 2, 4, 13, 1, 1, 1, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (23, 'Operation 3 de recette 3', 3, 2, 8, 0, 0, 1, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (24, 'Operation 4 de recette 3', 4, 3, 20, 0, 0, 1, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (25, 'Operation 5 de recette 3', 5, 1, 11, 0, 1, 1, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (26, 'Operation 6 de recette 3', 6, 4, 6, 0, 0, 1, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (27, 'Operation 7 de recette 3', 7, 3, 7, 0, 1, 0, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (28, 'Operation 8 de recette 3', 8, 4, 18, 0, 0, 0, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (29, 'Operation 9 de recette 3', 9, 1, 20, 0, 1, 0, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (30, 'Operation 10 de recette 3', 10, 2, 20, 0, 0, 1, 3);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (31, 'Operation 1 de recette 4', 1, 1, 5, 0, 0, 1, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (32, 'Operation 2 de recette 4', 2, 3, 20, 0, 0, 0, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (33, 'Operation 3 de recette 4', 3, 2, 20, 1, 1, 0, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (34, 'Operation 4 de recette 4', 4, 2, 15, 1, 0, 0, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (35, 'Operation 5 de recette 4', 5, 1, 14, 0, 1, 0, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (36, 'Operation 6 de recette 4', 6, 2, 18, 1, 0, 0, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (37, 'Operation 7 de recette 4', 7, 5, 10, 1, 1, 0, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (38, 'Operation 8 de recette 4', 8, 2, 20, 0, 1, 0, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (39, 'Operation 9 de recette 4', 9, 1, 15, 0, 1, 1, 4);
INSERT INTO Operation (Id_Operation, OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) VALUES (40, 'Operation 10 de recette 4', 10, 4, 17, 0, 1, 1, 4);