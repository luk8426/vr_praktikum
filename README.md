# Praktikum Virtuelle Realität - Lukas Kieninger
## Teil 1 - Roll a Ball

Die vorgegebene Funktionaliät habe ich dahingehend erweitert, dass der Ausgangspunkt, bzw. der Spawnpoint das **Level-Auswahl-Board** ist. An allen vier Seiten gibt es **Teleporter-Tore**, die sowohl Ball als auch den Spieler in die Level mit dem entsprechenden Schwierigkeitsgrad teleportieren. Die Level sind unterteilt in:
+ Easy 🟢
+ Intermediate 🟠
+ Hard 🔴 
+ Extreme ⚫

Die Farben finden sich auch im Layout der Boards wieder. Das Easy-Board besitzt keinerlei zusätzliche Features im Vergleich zu dem im Tutorial gefertigten Board. Das **Level Hard** besitzt zusätzlich einen **Gegner**, der den eignenen Ball jagt. Bei einer Berührung gilt das Level als sofort verloren und man landet wieder am Level-Auswahl-Board. Das **Level Extreme** habe ich um **zwei hin und her rollende Säulen** erweitert. Bei jedem Richtungswechsel der rollenden Säulen **verändern diese ihre Länge** wobei immer genug Platz bleibt, dass der Ball noch durch mindestens eine der Lücken passt. Genau wie beim Level Hard gilt auch hier bei einer Berührung der Säulen mit dem Ball das Spiel als sofort verloren und Ball und Spieler werden zurück zum Ausgangspunkt teleportiert.

**TODO!!!!!!!!!!!** Videolink einfügen 

## Teil 2 - Flugsimulator - Szene Inspection
Die Inspection-Szene gestaltet sich recht unspektakulär. Allgemein findet man sich auf einem Flugfeld wieder und kann sich die Gebäude und Objekte dort ansehen. Außerdem funktioniert auch der Teleporter wie in der Aufgabenstellung verlangt. Hinzugefügt habe ich noch Parikel, die aus den Triebwerken des Helicopters der beim Aufsetzen der VR-Brille direkt im Blickfeld steht, strömen. Außerdem hört man vom Helikopter ausgehend ein Geräusch, dass den Eindruck erweckt, dass die Triebwerke auch wirklich bereits laufen. Die Rotoren habe ich hier absichtlich noch nicht drehen lassen, auch wenn es in der Aufgabenstellung vorgeschlagen wurde, da ich es merkwürdig fand, wenn diese sich drehen würden, ohne dass ein Pilot im Cockpit sitzt.
Läuft man dann auf die hintere rechte Türe des Helikopters zu, kann man diese Greifen und nach links bis zum Anschlag ziehen (nach rechts sollte nicht möglich sein). Öffnet man diese Türe weit genug, wird man in die Cockpit bzw. Hand Interaction Szene teleportiert. 

## Teil 3 - Flugsimulator - Szene Hand Interaction
# Die Story
Befindet man sich im Cockpit, ertönt zunächst eine Willkommensnachricht aus dem kleinen Lautsprecher, der sich links von einem befindet. Die Stimme erteilt einem den Auftrag in Richtung Süden zu fliegen. Wem man dies befolgt, sieht man schon bald eine gelbe Säule mit gelben Partikeln aufsteigen. Durch diese Säule gilt es zu fliegen, um Hilfsgüter aufzuladen. Die Stimme ertönt erneut und erklärt wie es weitergeht: Man soll zum Dorf fliegen um dieses mit den aufgesammelten Hilfsgütern zu versorgen. Dazu orientiert man sich wieder an einer gelben Säule. Sobald man auch diese Säule durchflogen hat, ertönt wieder die Stimme und bedankt sich. Man sollte nur noch die Hilfsgüter auch wirklich abwerfen. Dazu muss man den Helikopter über der Zielscheibe platzieren und dann den Knopf mit der Kiste (rechts im Cockpit) drücken. Sollte man nicht treffen wird die Kiste zurückgesetzt. Man sieht, dass man getroffen hat, indem die Kiste auch wirklich stehen bleibt. Anschließend kann man zurückfliegen. Meist ist es durch den langen Tag dunkel geworden, sodass am Flughafen bereits bei der Rückkehr die Lichter an sind.

Mittels des Kompass in der Mittelkonsole kann man sich orientieren, um nicht in die falsche Richtung zu fliegen. Gleichzeitig beginnen sich sowohl der Heck-Rotor als auch der Hauptrotor zu drehen, was wieder durch ein entsprechendes Soundfile bestärkt wird. Die Steuerung der Flugzeugs geschieht mittels eines externen Joysticks. Zwar habe ich viel Zeit investiert, einen Joystick in das Flugzeug zu setzen, und das gelang auch mit Erfolg sodass ich sogar die Bewegungen des Helikopters über das Skript flyXR.cs steuern konnte, jedoch verlor der Joystick wenn er losgelassen wurde seine Beziehung zum Player Objekt und blieb damit einfach in der Welt stehen. Ich entschied mich daher auf das externe Gerät zurückzugreifen. Alternativ kann nach Aktivierung 
