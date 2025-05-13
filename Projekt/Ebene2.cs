using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projekt
{
    internal class Ebene2
    {
        public static void StoryEbene2(Kampflogik kampflogik, Spieler spieler1)
        {

            Gegner statueritter = new Gegner("StatueRitter", 30, 5, 10);
            Gegner verloreneSeele = new Gegner("VerloreneSeele", 35, 6, 11);
            Gegner skelettBestie = new Gegner("SkeletteBestie", 35, 6, 15);
            Gegner trollDaemon = new Gegner("TrollDaemon", 50, 7, 20);
            Spieler spieler = new Spieler("name", 0, 0, 0);


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
            kampflogik.Kämpfe(spieler, statueritter);

            //abzweigung 2
            Console.WriteLine("Du gehst tiefer in die Gruft. Aus allen Richtungen scheinen dir Stimmen zuzuflüstern.");
            Console.WriteLine("Drei neue Gänge stehen dir offen:");
            Console.WriteLine("1 - Ein dunkler Gang mit krummen Säulen");
            Console.WriteLine("2 - Eine enge Tür, durch die schwaches Kerzenlicht dringt");
            Console.WriteLine("3 - Ein halb eingestürzter Korridor mit Spinnweben");

            //auswahl 1 weg 2
            Console.WriteLine("Plötzlich erscheint eine schwebende Gestalt mit leuchtenden Augen.");
            Console.WriteLine("Sie schreit in alter Sprache und stürzt sich auf dich!");
            kampflogik.Kämpfe(spieler, verloreneSeele);

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
            kampflogik.Kämpfe(spieler, skelettBestie);

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

            kampflogik.Kämpfe(spieler, trollDaemon);

            // Nachdem der Miniboss besiegt ist und die Spieler die 3. Ebene betreten haben
            Console.WriteLine("Der Trolldämon fällt zu Boden, besiegt.");
            Console.WriteLine("Mit einem lauten Krachen zerbricht die Wand hinter ihm, und ein neuer Weg öffnet sich.");
            Console.WriteLine("Du gehst weiter und trittst in die dritte Ebene des Labyrinths ein.");


        }
    }
}
        

        