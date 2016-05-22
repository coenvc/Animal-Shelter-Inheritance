# Toelichting klassendiagram

Alle communicatie met de klassen zal via de centrale `Reservation` klasse
lopen. Deze beheert de aanwezige dieren in het asiel: het registreren van een
nieuwe kat of hond verloopt dan ook via deze klasse. Via deze klasse kan ook
een eventueel reeds geregistreerd dier opgevraagd worden.

Voor nu zijn er twee soorten dieren te registreren, katten en honden. Voor
katten wordt in de `Cat` klasse bijgehouden wat de naam en het geslacht is.
Ook hebben katten de neiging slechte gewoontes te hebben, wat geregistreerd
wordt onder het `badHabits` attribuut. Voor de `Dog` klasse geldt grotendeels
hetzelfde, maar in plaats van de gewoontes van het dier wordt bijgehouden
wanneer deze voor het laatst uitgelaten is: het `lastWalk` attribuut.

Beide dieren kunnen gereserveerd worden. Voor de `reserve` methode is een naam
benodigd: dit is de naam van de persoon die voornemens het dier te kopen. Voor
het aanmaken van een instantie van de `Reservor` klasse is ook een datum nodig
zodat bijgehouden kan worden hoe lang een dier al gereserveerd is. Het
reserveren van een dier dient deze datum altijd op vandaag te zetten bij het
maken van de reservering. Mocht een dier al gereserveerd zijn, kan deze niet
nogmaals gereserveerd worden: dit is de reden waarom de `reserve` methode een
boolean retourneert.

De `toString` methode tot slot wordt gebruikt om de informatie voor een dier
makkelijk op het scherm te kunnen tonen. Alle informatie die opgeslagen staat
in een instantie wordt hierin omgezet naar tekst.

