// abstracte klasse kann ich schon in der auswahl der rollen anhandeln

// public abstract class Rolle
// 



//Startmenü
//Klassenauswahl 
// Namenauswahl 
//kampfsystem
//shopsystem

// abzweigung 1
using System;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Du betrittst die finsteren Hallen der Schatten.");
Console.WriteLine("Ein kalter Wind weht durch die zerfallenen Mauern.");
Console.WriteLine("Vor dir verzweigen sich drei Gänge.");
Console.WriteLine("1 - Gehe nach links");
Console.WriteLine("1 - Gehe durch den schmalen Spalt direkt vor dir");
Console.WriteLine("3 - Gehe nach rechts");

// auswahl 1 weg1
Console.WriteLine("Plötzlich raschelt es im Dunkeln!");
Console.WriteLine("Eine Schattenratte greift dich an!");
// Hier dann kampfsystem einfügen 

//auswahl 2 weg1
Console.WriteLine("Du zwängst dich durch den Spalt und findest eine versteckte Nische.");
Console.WriteLine("In einer Truhe findest du 20 Goldmünzen!");
// Gold hinzufügen

//auswahl 3 weg1
Console.WriteLine("Du läufst einen dunklen Gang entlang...");
Console.WriteLine("...nur um festzustellen, dass du vor einer zugemauerten Wand stehst.");
Console.WriteLine("Zeitverschwendung. Du kehrst um.");

//man kommt nur weiter wenn man gegen gekämpft hat bei weg 1

//abzweigung 2
Console.WriteLine("Nach dem letzten Kampf atmest du schwer.");
Console.WriteLine("Die Gänge verzweigen sich erneut.");
Console.WriteLine("1 - Gehe geradeaus");
Console.WriteLine("2 - Folge dem modrigen Gang zur linken Seite");
Console.WriteLine("3 - Biege in den mit Spinnweben bedeckten Tunnel rechts ein");

//auswahl 1 weg2
Console.WriteLine("Du betrittst einen Raum mit einem alten, grinsenden Händler.");
Console.WriteLine("Händler: 'Willkommen, Reisender! Möchtest du etwas kaufen?'");
Console.WriteLine("1 - Dolch (+2 Schaden) - 20 Gold");
Console.WriteLine("2 - Lederweste (+5 HP) - 15 Gold");
Console.WriteLine("3 - Heiltrank (+20 HP) - 10 Gold");
Console.WriteLine("0 - Nichts kaufen");

//auswahl 2 weg2
Console.WriteLine("Ein fauliger Geruch liegt in der Luft...");
Console.WriteLine("Plötzlich springt ein Knochenkrabbler aus einem Haufen alter Schädel!");
Console.WriteLine("Der Kampf beginnt!");
// Kampfsystem starten

//auswahl 3 weg2
Console.WriteLine("Du verirrst dich in einen von Spinnweben bedeckten Tunnel...");
Console.WriteLine("...und findest nichts außer einer toten Spinne.");
Console.WriteLine("Sackgasse. Du gehst zurück.");

//man kommt nur weiter wenn man gegner bekämpft hat bei weg 2

//abzweigung 3
Console.WriteLine("Du schreitest tiefer in die düsteren Hallen.");
Console.WriteLine("Drei Gänge führen in unterschiedliche Richtungen:");
Console.WriteLine("1 - Ein Gang, aus dem ein Kratzen zu hören ist");
Console.WriteLine("2 - Ein schmaler Seitengang mit einer leuchtenden Fackel an der Wand");
Console.WriteLine("3 - Ein langer, stiller Tunnel mit eingestürztem Boden");
//auswahl 1 weg 3
Console.WriteLine("Du gehst dem Kratzen nach...");
Console.WriteLine("Eine riesige Schattenspinne krabbelt von der Decke herab!");
Console.WriteLine("Der Kampf beginnt!");
// Kampfsystem starten


//auswahl 2 weg 3
Console.WriteLine("Der Gang endet in einem kleinen Raum.");
Console.WriteLine("In einer Ecke findest du eine alte Truhe.");
Console.WriteLine("Du öffnest sie vorsichtig und findest:");
Console.WriteLine("- 15 Gold");
Console.WriteLine("- 1x Heiltrank");
// Loot zum Inventar hinzufügen
//aushwahl 3 weg 3
Console.WriteLine("Du folgst dem Tunnel...");
Console.WriteLine("Doch der Boden bricht plötzlich unter dir ein!");
Console.WriteLine("Du kannst dich gerade noch festhalten und zurückklettern.");
Console.WriteLine("Sackgasse. Du kehrst um.");

// man kommt erst weiter wieder wenn man gekämpft hat 

Console.WriteLine("Du erreichst eine große Steintür mit eingravierten Symbolen.");
Console.WriteLine("Als du sie öffnest, spürst du sofort eine drückende Präsenz.");
Console.WriteLine("In der Mitte der Halle steht eine dunkle Gestalt, umgeben von schwarzem Nebel.");
Console.WriteLine("Es ist der 'Finsterwächter' – der Hüter des Ebenenübergangs!");
Console.WriteLine("Er hebt sein verfluchtes Schwert und schreit: 'Niemand passiert diesen Punkt!'");

Console.WriteLine("Der Kampf gegen den Miniboss beginnt!");
// Starte Miniboss-Kampf 1
Console.WriteLine("Du hast den Finsterwächter besiegt!");
Console.WriteLine("Sein Körper zerfällt zu Staub und gibt den Weg zur nächsten Ebene frei.");
Console.WriteLine("Du findest 40 Gold und ein mächtiges Item: 'Splitter der Schattenrüstung' (+10 HP)");
Console.WriteLine("Ein Speicherpunkt erscheint. Möchtest du speichern?");
//Speicher punkt setzen

// start ebene 2 
//abzweigung 1
Console.WriteLine("Du betrittst die zweite Ebene: Eine uralte Gruft, in der der Tod selbst zu wohnen scheint.");
Console.WriteLine("Feuchte Mauern, knarrende Steine und flackernde Fackeln säumen deinen Weg.");
Console.WriteLine("Drei neue Wege tun sich vor dir auf:");
Console.WriteLine("1 - Ein schmaler Durchgang mit einem flackernden, blauen Licht");
Console.WriteLine("2 - Ein Seitengang, in dem Knochen auf dem Boden verstreut liegen");
Console.WriteLine("3 - Ein Gang voller uralter Statuen mit gebrochenen Gesichtern");

//auswahl 1 weg 1 
Console.WriteLine("Du findest eine alte Krypta mit einer halboffenen Grabkammer.");
Console.WriteLine("Darin liegt ein verwitterter Rucksack mit:");
Console.WriteLine(" 10 Gold");

// asuwahl 2 weg 1 
Console.WriteLine("Du trittst in den Knochenraum.");
Console.WriteLine("Eine Falle wird ausgelöst – Pfeile schießen aus der Wand!");
Console.WriteLine("Du kannst ausweichen, aber der Weg ist blockiert.");
Console.WriteLine("Sackgasse. Du kehrst zurück.");

//auswahl 3 weg 1
Console.WriteLine("Kaum betrittst du den Gang, dreht sich eine Statue zu dir um.");
Console.WriteLine("Sie erwacht zum Leben und greift dich an!");
// Kampf gegen Statueritter starten

//abzweigung 2
Console.WriteLine("Du gehst tiefer in die Gruft. Aus allen Richtungen scheinen dir Stimmen zuzuflüstern.");
Console.WriteLine("Drei neue Gänge stehen dir offen:");
Console.WriteLine("1 - Ein dunkler Gang mit krummen Säulen");
Console.WriteLine("2 - Eine enge Tür, durch die schwaches Kerzenlicht dringt");
Console.WriteLine("3 - Ein halb eingestürzter Korridor mit Spinnweben");

//auswahl 1 weg 2
Console.WriteLine("Plötzlich erscheint eine schwebende Gestalt mit leuchtenden Augen.");
Console.WriteLine("Sie schreit in alter Sprache und stürzt sich auf dich!");
// Kampf gegen die „Verlorene Seele“ starten

//auswahl 2 weg 2 
Console.WriteLine("Du findest einen verlassenen Altarraum.");
Console.WriteLine("Auf dem Altar liegt eine kleine Truhe.");
Console.WriteLine("Darin findest du:");
Console.WriteLine(" 20 Gold");

//auswahl 3 weg 2
Console.WriteLine("Du kämpfst dich durch Spinnweben, aber der Gang endet abrupt.");
Console.WriteLine("Ein einstürzendes Deckenteil zwingt dich zur Umkehr.");
Console.WriteLine("Sackgasse. Zurück zum Ausgangspunkt.");

//abzweigung 3 
Console.WriteLine("Du erreichst einen schmalen Gang, der in eine feuchte, dunkle Kammer führt.");
Console.WriteLine("In der Mitte befindet sich ein alter, eingestürzter Brunnenschacht.");
Console.WriteLine("Aus dem Loch strömt kalte Luft, begleitet von unheimlichem Flüstern.");
Console.WriteLine("Es gibt drei Wege vor dir:");
//Auswahl 
Console.WriteLine("A - Ein Raum voller Knochen, der nach Tod riecht.");
Console.WriteLine("B - Ein Vorraum, in dem seltsam leuchtende Pilze wachsen.");
Console.WriteLine("C - Eine versteckte Nische in der Wand, kaum sichtbar im Dämmerlicht.");
Console.WriteLine("Wähle deinen Weg weise – nicht jeder führt zum Ziel...");

// auswahl 1 weg 3 
Console.WriteLine("Du betrittst den Raum voller Knochen.");
Console.WriteLine("Die Luft ist schwer, und der Boden knirscht unter deinen Füßen.");
Console.WriteLine("Plötzlich erheben sich die Knochen zu einer Skelettbestie!");
Console.WriteLine("Ein Kampf beginnt!");
// kampf 

// auswahl 2 weg 3
Console.WriteLine("Du betrittst den Raum mit den leuchtenden Pilzen.");
Console.WriteLine("Es ist still, nur das leise Knistern der Sporen ist zu hören.");
Console.WriteLine("Ein schmaler Durchgang hinter einer Pilzsäule führt dich tiefer in die Ebene.");
Console.WriteLine("Du kommst sicher weiter.");
// weiterkommen ohne kampf 

//auswahl 3 weg 3 
Console.WriteLine("Du zwängst dich in die enge Nische.");
Console.WriteLine("Am Ende findest du eine alte Truhe – leer.");
Console.WriteLine("Plötzlich stürzt ein Teil der Wand ein – du musst umkehren.");

// händler 
Console.WriteLine("Du betrittst einen kleinen, ruhigen Raum.");
Console.WriteLine("Ein alter, bärtiger Händler sitzt auf einem Hocker neben einer flackernden Laterne.");
Console.WriteLine("\"Ah, ein Reisender! Möchtest du handeln?\" fragt er freundlich.");
Console.WriteLine("Vor dir stehen ein paar nützliche Gegenstände zum Verkauf.");
//shop wieder hinzufügen

// miniboss ebene 2 
Console.WriteLine("Der Gang wird kälter und dunkler.");
Console.WriteLine("Du spürst eine bedrohliche Präsenz – etwas wartet auf dich.");
Console.WriteLine("Mit jedem Schritt dröhnt der Boden unter deinen Füßen.");
Console.WriteLine("Hinter einer schweren Steintür erwartet dich der Hüter der dir den durchgang zur nächsten Ebene blockiert.");

// boss ebene 2 
Console.WriteLine("Plötzlich hörst du ein tiefes Knurren und eine bedrohliche Gestalt tritt aus dem Schatten.");
Console.WriteLine("'Ein gewaltiger Trolldämon, stellt sich dir in den Weg!");
Console.WriteLine("\"Du wagst es, dich mir zu stellen?\", brüllt er mit rauer Stimme.");
Console.WriteLine("Bereite dich vor auf einen harten Kampf!");
Console.WriteLine("Es gibt keinen Rückzug – du musst diesen Feind besiegen, um weiterzukommen.");
Console.WriteLine("Der Kampf beginnt jetzt...");

// Kampfmethode ();

// Nachdem der Miniboss besiegt ist und die Spieler die 3. Ebene betreten haben
Console.WriteLine("Der Trolldämon fällt zu Boden, besiegt.");
Console.WriteLine("Mit einem lauten Krachen zerbricht die Wand hinter ihm, und ein neuer Weg öffnet sich.");
Console.WriteLine("Du gehst weiter und trittst in die dritte Ebene des Labyrinths ein.");

// letzte ebene weg 1
// Erster Abschnitt der dritten Ebene:
Console.WriteLine("Du betrittst die dritte Ebene: Ein finsterer Raum, dessen Wände mit dichten Schatten bedeckt sind.");
Console.WriteLine("Der Boden knirscht unter deinen Füßen, und du spürst, dass hier etwas Unheimliches lauert.");
Console.WriteLine("Drei Wege tun sich vor dir auf:");
Console.WriteLine("1 - Ein düsterer Gang, in dem das Licht schwach flackert");
Console.WriteLine("2 - Ein mystischer Raum, in dem das Wasser in leisen Strömen plätschert");
Console.WriteLine("3 - Ein steiniger Tunnel, aus dem ein seltsames Echo hallt");

// Weg 1: Kampf mit einem Gegner
Console.WriteLine("Du wählst den düsteren Gang.");
Console.WriteLine("Du stößt auf einen alten Wächter, der dich mit einem grimmigen Blick ansieht.");
Console.WriteLine("Er greift dich an! Du musst ihn besiegen, um weiterzukommen.");

// Weg 2: Sackgasse
Console.WriteLine("Du betrittst den mystischen Raum, in dem das Wasser plätschert.");
Console.WriteLine("Der Raum scheint endlos, doch plötzlich stürzt das Dach ein, und der Weg wird blockiert.");
Console.WriteLine("Sackgasse. Du kehrst zurück.");

// Weg 3: Kampf mit einem Gegner
Console.WriteLine("Du gehst weiter durch den steinigen Tunnel.");
Console.WriteLine("Aus den Schatten tritt ein weiterer Gegner hervor, bereit zum Angriff!");
Console.WriteLine("Du musst ihn besiegen, um weiterzukommen.");

// Zweiter Abschnitt der dritten Ebene:
Console.WriteLine("Nach dem Sieg gehst du weiter und gelangst zu einer weiteren Kreuzung.");
Console.WriteLine("Drei neue Wege tun sich auf:");
Console.WriteLine("1 - Ein Gang, in dem riesige Spinnenweben den Weg versperren");
Console.WriteLine("2 - Ein langer Tunnel, der ins Dunkel führt");
Console.WriteLine("3 - Ein Raum mit geheimen Türen, die nur durch das richtige Symbol geöffnet werden können");

// Weg 1: Kampf mit einem Gegner
Console.WriteLine("Du gehst in den Gang mit den Spinnenweben.");
Console.WriteLine("Plötzlich hörst du ein Kratzen, und eine riesige Spinne springt auf dich!");
Console.WriteLine("Du musst sie besiegen, um weiterzukommen.");

// Weg 2: Sackgasse
Console.WriteLine("Du gehst den langen Tunnel.");
Console.WriteLine("Der Tunnel wird immer enger, und du stößt schließlich auf eine Mauer.");
Console.WriteLine("Sackgasse. Du kehrst zurück.");

// Weg 3: Rätselraum
Console.WriteLine("Du trittst in den Raum mit den geheimen Türen.");
Console.WriteLine("Die Türen sind verschlossen, aber ein seltsames Symbol auf der Wand scheint der Schlüssel zu sein.");
Console.WriteLine("Nach einigem Überlegen entschlüsselst du das Symbol und öffnest die Tür.");

Console.WriteLine("Du findest einen versteckten Raum mit einem mystischen Artefakt und einer weiteren Weggabelung.");

// Dritter Abschnitt der dritten Ebene:
Console.WriteLine("Du gehst weiter und betrittst eine riesige Halle, die von rötlichem Licht durchflutet wird.");
Console.WriteLine("Vor dir erscheinen drei weitere Wege:");
Console.WriteLine("1 - Ein gewundener Gang mit leisen Schritten, die aus der Dunkelheit kommen");
Console.WriteLine("2 - Ein Raum mit steinerner Treppe, die nach oben führt");
Console.WriteLine("3 - Ein verwüsteter Raum mit zerbrochenen Möbeln und Trümmern");

// Weg 1: Kampf mit einem Gegner
Console.WriteLine("Du gehst den gewundenen Gang.");
Console.WriteLine("Ein düsterer Schatten erscheint vor dir und greift dich sofort an.");
Console.WriteLine("Du musst den Gegner besiegen, um weiterzukommen.");

// Weg 2: Sackgasse
Console.WriteLine("Du betrittst den Raum mit der steinernen Treppe.");
Console.WriteLine("Als du die Stufen hinaufsteigst, bricht der Boden unter dir ein, und du fällst in die Tiefe.");
Console.WriteLine("Sackgasse. Du kehrst zurück.");

// Weg 3: Kampf mit einem Gegner
Console.WriteLine("Du gehst in den verwüsteten Raum.");
Console.WriteLine("Ein riesiger Gegner taucht hinter den Trümmern auf und stürmt auf dich zu.");
Console.WriteLine("Du musst ihn besiegen, um weiterzukommen.");

//endboss
Console.WriteLine("Du erreichst eine letzte Raststätte – ein flackerndes Lagerfeuer brennt inmitten uralter Ruinen.");
Console.WriteLine("Ein alter Händler tritt aus dem Schatten hervor, als hätte er auf dich gewartet.");
Console.WriteLine("\"Du hast es fast geschafft... aber du wirst ihn nicht bezwingen ohne Vorbereitung,\" murmelt er.");
Console.WriteLine("Er bietet dir an, Heiltränke zu kaufen, Ausrüstung zu kaufen oder wieder zu gehen.");

// Das ist die letzte möglickeit um sachen einzukaufen 
Console.WriteLine("1 - Heiltrank kaufen");
Console.WriteLine("2 - Rüstung kaufen");
Console.WriteLine("3 - nichts kaufen und weiter ");

// Nach shop endboss 
Console.WriteLine("Nachdem du dich vorbereitet hast, schreitest du durch das letzte Tor.");
Console.WriteLine("Der Raum ist in Finsternis gehüllt, nur schwaches violettes Licht durchzieht den Boden.");
Console.WriteLine("Aus dem Nichts erklingt eine bekannte Stimme – es ist der Schatten, dem du im Labyrinth begegnet bist.");
Console.WriteLine("\"Ich war nur ein Echo... er ist das Original,\" flüstert es, ehe es verstummt.");
Console.WriteLine("Dann steht er vor dir – der wahre Herr der Schatten, aus dessen Macht das Labyrinth geboren wurde.");
Console.WriteLine("Der Endkampf beginnt...");
//Kampflogik

//ende
Console.WriteLine("Mit deinem letzten Schlag fällt der Herr der Schatten zu Boden.");
Console.WriteLine("Ein markerschütternder Schrei erfüllt das Labyrinth – es beginnt zu beben.");
Console.WriteLine("Dunkle Energie strömt aus seinem Körper, löst sich auf... und verschwindet in deinem Schatten.");
Console.WriteLine("Ein kalter Schauer durchfährt dich. Plötzlich hörst du die Stimme erneut – nicht von außen, sondern in deinem Kopf.");
Console.WriteLine("\"Du hast ihn besiegt... und mich befreit.\"");
Console.WriteLine("\"Doch der Preis war hoch... Ich bin nun ein Teil von dir.\"");

Console.WriteLine("Du blickst an dir herab – dein Schatten bewegt sich eigenständig.");
Console.WriteLine("Die Macht des Labyrinths ist nicht vernichtet. Sie hat nur den Wirt gewechselt.");
Console.WriteLine("Ein Gefühl durchströmt dich – stärker als je zuvor. Doch auch gefährlicher.");
Console.WriteLine("Die Welt ist sicher... fürs Erste.");
Console.WriteLine();
Console.WriteLine("== ENDE ==");
Console.WriteLine("Doch vielleicht... beginnt jetzt eine ganz andere Geschichte.");


