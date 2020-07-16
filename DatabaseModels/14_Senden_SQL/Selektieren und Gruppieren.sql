SELECT 
vorschubantrieb.zahnriemen.idZahnriemen,
vorschubantrieb.zahnriemen.Typ,
vorschubantrieb.zahnriemen.Laenge,
vorschubantrieb.zahnscheiben.idScheiben,
vorschubantrieb.zahnscheiben.Typ,
vorschubantrieb.zahnscheiben.Zaehnezahl,
vorschubantrieb.zahnscheiben.Durchmesser
FROM vorschubantrieb.zahnriemen
JOIN vorschubantrieb.zahnscheiben
WHERE (vorschubantrieb.zahnriemen.Typ = vorschubantrieb.zahnscheiben.Typ)
ORDER By vorschubantrieb.zahnriemen.Typ;	
