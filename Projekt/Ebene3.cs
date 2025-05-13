using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Ebene3
    {
        public static void StoryEbene3(Kampflogik kampflogik, Spieler spieler1)
        {
            Gegner wächter = new Gegner("AlterWächter", 30, 5, 10);
            Gegner geist = new Gegner("Geist", 35, 6, 11);
            Gegner tiger = new Gegner("Tiger", 35, 6, 15);
            Gegner kleinerSchatten = new Gegner("KleinerSchatten", 50, 7, 20);
            Gegner steinGolem = new Gegner("SteinGolem", 50, 7, 20);
            Gegner herrSchatten = new Gegner("HerrderSchatten", 250, 25, 45);
            Spieler spieler = new Spieler("name", 0, 0, 0);


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
            kampflogik.Kämpfe(spieler, wächter);

            // Weg 2: Sackgasse
            Console.WriteLine("Du betrittst den mystischen Raum, in dem das Wasser plätschert.");
            Console.WriteLine("Der Raum scheint endlos, doch plötzlich stürzt das Dach ein, und der Weg wird blockiert.");
            Console.WriteLine("Sackgasse. Du kehrst zurück.");

            // Weg 3: Kampf mit einem Gegner
            Console.WriteLine("Du gehst weiter durch den steinigen Tunnel.");
            Console.WriteLine("Aus den Schatten tritt ein weiterer Gegner hervor, bereit zum Angriff!");
            Console.WriteLine("Du musst ihn besiegen, um weiterzukommen.");
            kampflogik.Kämpfe(spieler, geist);

            // Zweiter Abschnitt der dritten Ebene:
            Console.WriteLine("Nach dem Sieg gehst du weiter und gelangst zu einer weiteren Kreuzung.");
            Console.WriteLine("Drei neue Wege tun sich auf:");
            Console.WriteLine("1 - Ein Gang, in dem riesige Spinnenweben den Weg versperren");
            Console.WriteLine("2 - Ein langer Tunnel, der ins Dunkel führt");
            Console.WriteLine("3 - Ein Raum mit geheimen Türen, die nur durch das richtige Symbol geöffnet werden können");

            // Weg 1: Kampf mit einem Gegner
            Console.WriteLine("Du gehst in den Gang mit den Spinnenweben.");
            Console.WriteLine("Plötzlich hörst du ein Kratzen, und eine riesiger Tiger springt auf dich!");
            Console.WriteLine("Du musst sie besiegen, um weiterzukommen.");
            kampflogik.Kämpfe(spieler,tiger);

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
            kampflogik.Kämpfe(spieler, kleinerSchatten);

            // Weg 2: Sackgasse
            Console.WriteLine("Du betrittst den Raum mit der steinernen Treppe.");
            Console.WriteLine("Als du die Stufen hinaufsteigst, bricht der Boden unter dir ein, und du fällst in die Tiefe.");
            Console.WriteLine("Sackgasse. Du kehrst zurück.");

            // Weg 3: Kampf mit einem Gegner
            Console.WriteLine("Du gehst in den verwüsteten Raum.");
            Console.WriteLine("Ein riesiger Gegner taucht hinter den Trümmern auf und stürmt auf dich zu.");
            Console.WriteLine("Du musst ihn besiegen, um weiterzukommen.");
            kampflogik.Kämpfe(spieler, steinGolem);

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
            kampflogik.Kämpfe(spieler, herrSchatten);

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

        }
    }
}
