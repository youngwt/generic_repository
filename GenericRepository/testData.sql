
INSERT INTO Artists (Id, Name) VALUES
('772d0de7-7c41-4d5d-bba5-66576144fc76', 'The Beatles'),
('a32a1ba8-3aec-4e8c-9bc4-aac3f97ea86f', 'Oasis');

-- Beatles album and Song
INSERT INTO Releases (Id, Name, Year, ReleaseType, ArtistId) VALUES ('2c6efd54-049f-49a7-a7a3-a51445de4d95', 'Abbey Road', 1969, 2, '772d0de7-7c41-4d5d-bba5-66576144fc76');
INSERT INTO Songs(Id, Name, ArtistId, ReleaseId) VALUES ('3cbfb620-8d90-4472-bd3a-569b55c89253', 'Here comes the sun', '772d0de7-7c41-4d5d-bba5-66576144fc76', '2c6efd54-049f-49a7-a7a3-a51445de4d95');

-- Oasis Album and single
INSERT INTO Releases (Id, Name, Year, ReleaseType, ArtistId) VALUES ('6dd344f7-37f5-45df-ba61-d1e8726b7038', '(What''s the story) Morning Glory', 1995, 2, 'a32a1ba8-3aec-4e8c-9bc4-aac3f97ea86f');
INSERT INTO Releases (Id, Name, Year, ReleaseType, ArtistId) VALUES ('241bf871-d32b-4e99-9fed-f12b02e30e77', 'Wonderwall', 1996, 0, 'a32a1ba8-3aec-4e8c-9bc4-aac3f97ea86f');
INSERT INTO Releases (Id, Name, Year, ReleaseType, ArtistId) VALUES ('313a1728-5e7a-4e95-a303-a810b859f00d', 'The Hindu Times', 2002, 0, 'a32a1ba8-3aec-4e8c-9bc4-aac3f97ea86f');

-- Album tracks
INSERT INTO Songs(Id, Name, ArtistId, ReleaseId) VALUES ('fdb3ebf4-c22a-49fa-8e12-e509e2ebe59f', 'Champagne Supernova', 'a32a1ba8-3aec-4e8c-9bc4-aac3f97ea86f', '6dd344f7-37f5-45df-ba61-d1e8726b7038');

-- b-sides
INSERT INTO Songs(Id, Name, ArtistId, ReleaseId) VALUES ('1f064c5d-fab1-4bc8-a26f-fb6f9b9d584d', 'Round our way', 'a32a1ba8-3aec-4e8c-9bc4-aac3f97ea86f', '241bf871-d32b-4e99-9fed-f12b02e30e77');
INSERT INTO Songs(Id, Name, ArtistId, ReleaseId) VALUES ('dd1909c5-ff51-4eda-a383-3f17a121493c', 'Just Getting Older', 'a32a1ba8-3aec-4e8c-9bc4-aac3f97ea86f', '313a1728-5e7a-4e95-a303-a810b859f00d');