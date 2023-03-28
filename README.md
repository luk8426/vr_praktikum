# Praktikum Virtuelle Realität - Lukas Kieninger
## Termin 1 - Roll a Ball

Die vorgegebene Funktionaliät habe ich dahingehend erweitert, dass der Ausgangspunkt, bzw. der Spawnpoint das **Level-Auswahl-Board** ist. An allen vier Seiten gibt es **Teleporter-Tore**, die sowohl Ball als auch den Spieler in die Level mit dem entsprechenden Schwierigkeitsgrad teleportieren. Die Level sind unterteilt in:
+ Easy 🟢
+ Intermediate 🟠
+ Hard 🔴 
+ Extreme ⚫

Die Farben finden sich auch im Layout der Boards wieder. Das Easy-Board besitzt keinerlei zusätzliche Features im Vergleich zu dem im Tutorial gefertigten Board. Das **Level Hard** besitzt zusätzlich einen **Gegner**, der den eignenen Ball jagt. Bei einer Berührung gilt das Level als sofort verloren und man landet wieder am Level-Auswahl-Board. Das **Level Extreme** habe ich um **zwei hin und her rollende Säulen** erweitert. Bei jedem Richtungswechsel der rollenden Säulen **verändern diese ihre Länge** wobei immer genug Platz bleibt, dass der Ball noch durch mindestens eine der Lücken passt. Genau wie beim Level Hard gilt auch hier bei einer Berührung der Säulen mit dem Ball das Spiel als sofort verloren und Ball und Spieler werden zurück zum Ausgangspunkt teleportiert.
