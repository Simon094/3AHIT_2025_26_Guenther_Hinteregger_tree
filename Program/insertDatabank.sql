INSERT OR IGNORE INTO Person
(Id, Name, Birthdate, Deathdate, IsMarried, IsMale, Job, School, FatherId, MotherId, Image)
VALUES
(7, 'Günther Hinteregger', '1970-10-09', NULL, 1, 1, 'Arzt', 'HTL-Weiz', 67, NULL, NULL);

INSERT OR IGNORE INTO FamilyTree
(Name)
VALUES
('Stammbaum der Familie Hinteregger!');