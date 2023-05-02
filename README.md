# Praktikum Virtuelle Realität - Lukas Kieninger
### Teil 1 - Roll a Ball

Die vorgegebene Funktionaliät habe ich dahingehend erweitert, dass der Ausgangspunkt, bzw. der Spawnpoint das **Level-Auswahl-Board** ist. An allen vier Seiten gibt es **Teleporter-Tore**, die sowohl Ball als auch den Spieler in die Level mit dem entsprechenden Schwierigkeitsgrad teleportieren. Die Level sind unterteilt in:
+ Easy 🟢
+ Intermediate 🟠
+ Hard 🔴 
+ Extreme ⚫

Die Farben finden sich auch im Layout der Boards wieder. Das Easy-Board besitzt keinerlei zusätzliche Features im Vergleich zu dem im Tutorial gefertigten Board. Das **Level Hard** besitzt zusätzlich einen **Gegner**, der den eignenen Ball jagt. Bei einer Berührung gilt das Level als sofort verloren und man landet wieder am Level-Auswahl-Board. Das **Level Extreme** habe ich um **zwei hin und her rollende Säulen** erweitert. Bei jedem Richtungswechsel der rollenden Säulen **verändern diese ihre Länge** wobei immer genug Platz bleibt, dass der Ball noch durch mindestens eine der Lücken passt. Genau wie beim Level Hard gilt auch hier bei einer Berührung der Säulen mit dem Ball das Spiel als sofort verloren und Ball und Spieler werden zurück zum Ausgangspunkt teleportiert.

**TODO!!!!!!!!!!!** Videolink einfügen 

### Teil 2 - Flugsimulator - Szene Inspection
Die Inspection-Szene gestaltet sich recht unspektakulär. Allgemein findet man sich auf einem Flugfeld wieder und kann sich die Gebäude und Objekte dort ansehen. Außerdem funktioniert auch der Teleporter wie in der Aufgabenstellung verlangt. Hinzugefügt habe ich noch Parikel, die aus den Triebwerken des Helicopters der beim Aufsetzen der VR-Brille direkt im Blickfeld steht, strömen. Außerdem hört man vom Helikopter ausgehend ein Geräusch, dass den Eindruck erweckt, dass die Triebwerke auch wirklich bereits laufen. Die Rotoren habe ich hier absichtlich noch nicht drehen lassen, auch wenn es in der Aufgabenstellung vorgeschlagen wurde, da ich es merkwürdig fand, wenn diese sich drehen würden, ohne dass ein Pilot im Cockpit sitzt.
Läuft man dann auf die hintere rechte Türe des Helikopters zu, kann man diese Greifen und nach links bis zum Anschlag ziehen (nach rechts sollte nicht möglich sein). Öffnet man diese Türe weit genug, wird man in die Cockpit bzw. Hand Interaction Szene teleportiert. 

### Teil 3 - Flugsimulator - Szene Hand Interaction
## Die Story
In einem Dorf, unweit des Flugplatzes ist ein Unfall passiert. Da das Gelände keine schnelle Versorgung mit Hilfsgütern über den Boden zulässt, ist die einzige Option eine Versorgung aus der Luft. Du erklärst Dich dazu bereit diese Aufgabe zu übernehmen. Bevor die Hilfgüter abwerfen kannst, musst Du diese aber zunächst abholen und fliegst zu einem kleinen See, an dem einige Kisten gelagert sind. Anschließend machst du die auf den Weg zu dem kleinen Dorf, in dem sich der Unfall ereignete, um die benötigten Hilfsgüter abzuwerfen.

## Die konkrete Umsetzung und Implementierung
# Im Cockpit: Flugsteuerung und Interaktion
Unmittelbar nach dem Betreten des Helikopters wird die initale Aufgabe des Aufladens, dem Spieler über dem kleinen Lautsprecher an der linken Seite mitgeteilt. Der Orientierung dient dabei der Kompass in der Mittelkonsole. Gleichzeitig beginnen sich sowohl der Heck-Rotor als auch der Hauptrotor zu drehen, was wieder durch ein entsprechendes Soundfile untermalt wird. 
Um fliegen zu können, benötigt man einen externen Joystick. Zwar habe ich viel Zeit investiert, einen Joystick in das Flugzeug zu setzen, und das gelang auch mit Erfolg sodass ich sogar die Bewegungen des Helikopters über das Skript flyXR.cs steuern konnte, jedoch verlor der Joystick wenn er losgelassen wurde seine Beziehung zum Player Objekt und blieb damit einfach in der Welt stehen. Ich entschied mich daher auf das externe Gerät zurückzugreifen. Alternativ kann nach Aktivierung des Skripts Fly.cs auch mit den Tasten W-A-S-D geflogen werden. Die Geschwindigkeit hingegen lässt sich über den schwarzen Schieberegler im Cockpit rechts des Piloten steuern. Dabei muss dieser nur geschoben und nicht gegiffen werden. Über die Buttons könne jeweils das Scheinwerferlicht, das HeadUpDisplay oder die Bodenkamera an- bzw. ausgeschalten werden. Zusätzlich lässt sich die Lage des Helikopters anhand des kleinen Modells in der Mittelkonsole erkennen (ausgenommen Yaw, da es keinen Sinn ergibt wenn der Modell-Helikopter in die falsche Richtung schaut)
