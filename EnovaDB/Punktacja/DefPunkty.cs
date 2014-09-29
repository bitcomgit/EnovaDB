
//
// Plik zawiera logikę biznesową kolekcji obiektów definicji punktacji.
// Taki plik należy przygotować dla każdego obiektu biznesowego zdefiniowanego w pliku *.business.xml.
// Kolekcja ta zarządza obiektami biznesowymi pewnego typu, tutaj definicjami punktów. Znajdują się
// w niej metody, które nie są specyficzne dla poszczególnych obiektów biznesowych,
//

//
// Wszystkie obiekty biznesowe zostały umieszczone w jednym namespace, którego nazwa została również 
// umieszczona w pliku *.business.xml (module/@namespace).
//
namespace Soneta.Examples.EnovaDB.Punktacja
{

    //
    // Nazwa klasy kolekcji obiektów biznesowych brana jest z nazwy elementu table znajdującego się w 
    // *.business.xml (atrybut table/@tablename).
    // Klasa ta musi dziedziczyć z klasy bazowej znajdującej się w wygenerowanym przez Soneta.Generator module
    // PunktacjaModule i klasy DefinicjaPunktuTable (do nazwy atrybutu @name dodano sufiks Table).
    // W klasie tej znajduje się między innymi implementacja properties reprezentujących klucze dostarczające 
    // obiekty w zadanej kolejności oraz metody pozwajające na odczytanie obiektu o zadanym Guid lub ID.
    //
    public class DefPunkty : PunktacjaModule.DefinicjaPunktuTable
    {
    }
}
