# Praktikum Virtuelle Realität - Lukas Kieninger
## Teil 1 - Roll a Ball

Die vorgegebene Funktionaliät habe ich dahingehend erweitert, dass der Ausgangspunkt, bzw. der Spawnpoint das **Level-Auswahl-Board** ist. An allen vier Seiten gibt es **Teleporter-Tore**, die sowohl Ball als auch den Spieler in die Level mit dem entsprechenden Schwierigkeitsgrad teleportieren. Die Level sind unterteilt in:
+ Easy 🟢
+ Intermediate 🟠
+ Hard 🔴 
+ Extreme ⚫

Die Farben finden sich auch im Layout der Boards wieder. Das Easy-Board besitzt keinerlei zusätzliche Features im Vergleich zu dem im Tutorial gefertigten Board. Das **Level Hard** besitzt zusätzlich einen **Gegner**, der den eignenen Ball jagt. Bei einer Berührung gilt das Level als sofort verloren und man landet wieder am Level-Auswahl-Board. Das **Level Extreme** habe ich um **zwei hin und her rollende Säulen** erweitert. Bei jedem Richtungswechsel der rollenden Säulen **verändern diese ihre Länge** wobei immer genug Platz bleibt, dass der Ball noch durch mindestens eine der Lücken passt. Genau wie beim Level Hard gilt auch hier bei einer Berührung der Säulen mit dem Ball das Spiel als sofort verloren und Ball und Spieler werden zurück zum Ausgangspunkt teleportiert. Wichtig ist dabei, dass man bei einem Teleportationsvorgang kein Board in der Hand hält, da dieses sonst mitteleportiert wird. Ein Video, das das Spiel zeigt, findet sich hier:
<figure class="video_container">
  <video controls="true" allowfullscreen="true" poster="Praktikum-Doku/Poster_RollABall.JPG">
    <source src="Praktikum-Doku/RollABall.mp4" type="video/mp4">
  </video>
</figure>

## Teil 2 - Flugsimulator - Szene Inspection
Die Inspection-Szene gestaltet sich recht unspektakulär. Allgemein findet man sich auf einem Flugfeld wieder und kann sich die Gebäude und Objekte dort ansehen. Außerdem funktioniert auch der Teleporter wie in der Aufgabenstellung verlangt. Hinzugefügt habe ich noch Parikel, die aus den Triebwerken des Helikopters strömen, der beim Aufsetzen der VR-Brille direkt im Blickfeld erscheint. Außerdem hört man vom Helikopter ausgehend ein Geräusch, dass den Eindruck erweckt, dass die Triebwerke auch wirklich bereits laufen. Die Rotoren habe ich hier absichtlich noch nicht drehen lassen, auch wenn es in der Aufgabenstellung vorgeschlagen wurde, da ich es merkwürdig fand, wenn diese sich drehen würden, ohne dass ein Pilot im Cockpit sitzt.
Läuft man dann auf die hintere rechte Türe des Helikopters zu, kann man diese Greifen und nach links bis zum Anschlag ziehen (nach rechts sollte nicht möglich sein). Öffnet man diese Türe weit genug, wechselt man in die Cockpit bzw. Hand Interaction Szene. 

## Teil 3 - Flugsimulator - Szene Hand Interaction
### Die Story
In einem Dorf, unweit des Flugplatzes ist ein Unfall passiert. Da das Gelände keine schnelle Versorgung mit Hilfsgütern über den Boden zulässt, ist die einzige Option eine Versorgung aus der Luft. Du erklärst Dich dazu bereit diese Aufgabe zu übernehmen. Bevor die Hilfgüter abwerfen kannst, musst Du diese aber zunächst abholen und fliegst zu einem kleinen See, an dem einige Kisten gelagert sind. Anschließend machst du dich auf den Weg zu dem kleinen Dorf, in dem sich der Unfall ereignete, um die benötigten Hilfsgüter abzuwerfen.
Das Video, dass die gesamte Story einmal durchspielt:
<figure class="video_container">
  <video controls="true" allowfullscreen="true" poster="Praktikum-Doku/Poster_Flugsimulator.JPG">
    <source src="https://drive.google.com/file/d/1KfK5EaJ6j6ANLqxcrfrFZYuFdU0GZyiX/view?usp=share_link" type="video/mp4">
  </video>
</figure>


### Die konkrete Umsetzung und Implementierung
#### _**Im Cockpit: Flugsteuerung und Interaktion**_
Unmittelbar nach dem Betreten des Helikopters wird die initale Aufgabe des Aufladens, dem Spieler über dem kleinen Lautsprecher an der linken Seite mitgeteilt. Der Orientierung dient dabei der Kompass in der Mittelkonsole. Gleichzeitig beginnen sich sowohl der Heck-Rotor als auch der Hauptrotor zu drehen, was wieder durch ein entsprechendes Soundfile untermalt wird.
Um fliegen zu können, benötigt man einen externen Joystick. Zwar habe ich viel Zeit investiert, einen Joystick in das Flugzeug zu setzen, und das gelang auch mit Erfolg sodass ich sogar die Bewegungen des Helikopters über das Skript _flyXR.cs_ steuern konnte, jedoch verlor der Joystick wenn er losgelassen wurde seine Beziehung zum Player Objekt und blieb damit einfach in der Welt stehen. Ich entschied mich daher auf das externe Gerät zurückzugreifen. Alternativ kann nach Aktivierung des Skripts _Fly.cs_ auch mit den Tasten W-A-S-D geflogen werden. Die Geschwindigkeit hingegen lässt sich über den schwarzen Schieberegler im Cockpit rechts des Piloten steuern. Dabei muss dieser nur geschoben und nicht gegiffen werden. Über die Buttons können jeweils das HeadUpDisplay, das Scheinwerferlicht oder die Bodenkamera an- bzw. ausgeschalten werden. Die Funktonsweise des Buttons _Kiste_ werde ich später erklären. Zusätzlich zu den Buttons, lässt sich die Lage des Helikopters gegenüber dem Boden anhand des kleinen Modells in der Mittelkonsole erkennen (ausgenommen Yaw, da es keinen Sinn ergibt wenn der Modell-Helikopter nach einer 180° Drehung nach hinten zeigt; im Video nicht korrekt zu erkennen). Das Bild der Bodenkamera ist auf eine Leiste die von der linken Cockpitseite absteht projeziert.
#### _**Aufgabe 1: Aufnehmen der Ladung**_
Sobald man sich dann auf in die Luft macht und gen Süden fliegt, sieht man bald gelbe Partikel in den Himmel steigen. Diese markieren das erste Ziel. Kommt man diesem Ziel noch näher, so erkennt man auch eine gelbe Säule. Diese bildet das eigentliche Ziel. Sobald man mit dem Helikopter durch diese Säule fliegt, erscheint eine Kiste unter dem Helikopter (die aufgeladene Ladung) und aus dem Lautsprecher an der Seite ertönt erneut eine Stimmme, die den Auftrag zum Absetzen der Last gibt. Außerdem färben sich mit dem Erreichen des ersten Ziels die aufsteigenden Parikel grün und das zweite Ziel (gelbe Säule + Partikel wird aktiviert). Jetzt kommt der Button _Kiste_ ins Spiel: Mit Drücken dieses Buttons wird ab sofort das Abwerfen der unterhalb des Helikopter erschienenen Kiste getriggert. Der Abwurfvorgang kann dabei durch die Bodenkamera beobachtet werden. Wenn die Kiste über Terrain abgeworfen wird, dann verschwindet sie beim Aufkommen und eine neue Kiste erscheint unterhalb des Helikopters. Diese Funktion ermöglichen die Skripte _Cargo.cs_ und _dropCargoOnButton.cs_.  
#### _**Aufgabe 2: Abliefern der Ladung**_
Die Zielmarkierung funktioniert genau gleich wie bei dem ersten Ziel. Sobald man durch die gelbe Säule geflogen ist, verschwindet diese und die Parikel färben sich grün. Analog ertönt auch wieder eine Stimme die das erfolgreiche Abschließen der Mission bestätigt. Man sollte jedoch nicht vergessen die Kiste auch noch abzuwerfen! Trifft man mit der Kiste die Zielscheibe, so bleibt die Kiste dort liegen und man kann keine weiteren Kisten mehr abwerfen. Hinzu kommt, dass mit Erreichen dieses Ziels ein Tag-Nacht-Wechsel ausgelöst wird. Das Skript _objective.cs_ bildet dabei Code-Grundlage für die Missions
### Die Umgebung
Die Umgebung besteht aus einem eigens aus verschiedensen Modellen zusammengestellten Flugplatz, einem abwechslungsreichen Wüstengelände mit Bergen, Hügeln, Oasen, Palmen und Felsen und einem kleinen Dorf. Zusätzlich gibt es diverse Lichter, wie beispielsweise eine rotierendes Scheinwerferlicht auf dem Tower oder die Innenbeleuchtung der Terminals. Jedes Licht besitzt eine Skriptkomponente _turnLightOnAtNight.cs_, die bei Aktivierung dafür sorgt, dass das Licht erst angeht, sollte es Nacht werden. Ich habe diese Komponenten deaktiviert, da Unity für Spotlights kein dynamisches Rendering unterstützt, was dazu führt, dass die Lichter sehr intensiv und weiß leuchten, sobald diese zur Laufzeit eingeschaltet werden:
![Shader cannot process dynamic spotlights](/Praktikum-Doku/ShaderUnableToHandleDynamicSpotlight.JPG)*Shader kann dynamische spotlights nicht richtig verarbeiten*

Durch pressen der Taste _N_ kann man zusätzlich direkt einen Wechsel zur Nacht auslösen und es beginnt lansgam dunkel zu werden. Ist eine gewisse Helligkeit unterschritten, ändert sich auch die angezeige Skybox. Außerdem legt sich sobald man die Szene betritt nach und nach mehr Nebel in die Landschaft. Beide Funktionalitäten sind im Skript _LightColorSwitch.cs_ implementiert.  

