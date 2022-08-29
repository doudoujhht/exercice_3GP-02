

long listeChaineFin(int nbElements)
{
    LinkedList<int> list = new LinkedList<int>();


    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

    for (int i = 0; i < 500000; i++)
    {
        list.AddFirst(i);
    }

    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    return apres - avant;
}
void listeTableau()
{
    List<int> list = new List<int>();


    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

    for (int i = 0; i < 500000; i++)
    {
        list.Insert(0,i);
    }

    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine(apres - avant);
}

void traverserListe()
{
    LinkedList<int> list = new LinkedList<int>();
    for (int i = 0; i < 500000; i++)
    {
        list.AddFirst(i);
    }

    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in list)
    {
        int tkt = i;
    }

    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

    Console.WriteLine(apres - avant);
}

void traverLinkedListNode(){
    LinkedList<int> list = new LinkedList<int>();
    for (int i = 0; i < 500000; i++)
    {
        list.AddFirst(i);
    }
    Console.WriteLine(list.First.Value);

    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    LinkedListNode<int> node = list.First;
    while (node != null)
    {
        int tkt = node.Value;
        node = node.Next;
    }

    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

    Console.WriteLine(apres - avant);
}

void parcourir()
{
    List<int> list = new List<int>();
    for (int i = 0; i < 125000; i++)
    {
        list.Add(i);
    }

    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < list.Count; i++)
    {
        int tkt = i;
    }

    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

    Console.WriteLine(apres - avant);
}

List<int> list = new List<int>();
LinkedList<int> linkedList = new LinkedList<int>();
SortedList<int, int> sortedList = new SortedList<int, int>();
SortedSet<int> sortedSet = new SortedSet<int>();
HashSet<int> linkedHashSet = new HashSet<int>();


int nombre = 500000;
int[] tableau = new int[nombre];
for (int i = 0; i < tableau.Length; i++)
{
    tableau[i] = i;
}
tableau = tableau.OrderBy(i => new Random().Next()).ToArray(); // stack overflow tu connais


void insererListe()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in tableau)
    {
        list.Add(i);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"insertion dans ArrayList: {apres - avant} millisecondes.");
}

void insererLinkedList()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in tableau)
    {
        linkedList.AddLast(i);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"insertion dans LinkedList: {apres - avant} millisecondes.");
}

void insererSortedList()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in tableau)
    {
        sortedList.Add(i,i);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"insertion dans SortedList: {apres - avant} millisecondes.");
}

void insererSortedSet()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in tableau)
    {
        sortedSet.Add(i);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"insertion dans SortedSet: {apres - avant} millisecondes.");
}

void insererHashSet()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in tableau)
    {
        linkedHashSet.Add(i);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"insertion dans Hashset: {apres - avant} millisecondes.");
}


void parcourirList()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in list)
    {
        int tkt = i;
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"parcours dans liste: {apres - avant} millisecondes.");
}

void parcourirLinkedList()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in linkedList)
    {
        int tkt = i;
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"parcours dans LinkedListe: {apres - avant} millisecondes.");
}

void parcourirHashSet()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in linkedHashSet)
    {
        int tkt = i;
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"parcours dans HashSet: {apres - avant} millisecondes.");
}

void parcourirSortedList()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in sortedList.Keys)
    {
        int tkt = i;
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"parcours dans Sortedlist: {apres - avant} millisecondes.");
}

void parcourirSortedSet()
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    foreach (int i in sortedSet)
    {
        int tkt = i;
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"parcours dans Sortedset: {apres - avant} millisecondes.");
}

void rechercherList(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        Boolean tkt = list.Contains(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"rechercher dans arrayListe: {apres - avant} millisecondes.");
}

void rechercherLinkedList(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        Boolean tkt = linkedList.Contains(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"rechercher dans LinkedList: {apres - avant} millisecondes.");
}

void rechercherHashSet(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        Boolean tkt = linkedHashSet.Contains(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"rechercher dans HashSet: {apres - avant} millisecondes.");
}

void rechercherSortedList(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        Boolean tkt = sortedList.ContainsKey(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"rechercher dans SortedList: {apres - avant} millisecondes.");
}

void rechercherSortedSet(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        Boolean tkt = sortedList.ContainsKey(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"rechercher dans SortedSet: {apres - avant} millisecondes.");
}


void supprimerList(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        list.Remove(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"suprimmer dans liste: {apres - avant} millisecondes.");
}

void supprimerLinkedList(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
       linkedList.Remove(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"suprimmer dans LinkedListe: {apres - avant} millisecondes.");
}

void supprimerHashSet(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        linkedHashSet.Remove(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"suprimmer dans HashList: {apres - avant} millisecondes.");
}

void supprimerSortedList(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        sortedList.Remove(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"suprimmer dans SortedList: {apres - avant} millisecondes.");
}

void supprimerSortedSet(int nombre)
{
    long avant = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    for (int i = 0; i < nombre; i++)
    {
        sortedSet.Remove(tableau[i]);
    }
    long apres = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    Console.WriteLine($"suprimmer dans SortedSet: {apres - avant} millisecondes.");
}



Console.WriteLine($"temps pour {nombre} d'éléments dans le tableau");
Console.WriteLine();

insererListe();
insererLinkedList();
insererHashSet();
insererSortedList();
insererSortedSet();

Console.WriteLine();

parcourirList();
parcourirLinkedList();
parcourirHashSet();
parcourirSortedList();
parcourirSortedSet();

Console.WriteLine();

rechercherList(nombre);
rechercherLinkedList(nombre);
rechercherHashSet(nombre);
rechercherSortedList(nombre);
rechercherSortedSet(nombre);

Console.WriteLine();

supprimerList(nombre);
supprimerLinkedList(nombre);
supprimerHashSet(nombre);
supprimerSortedList(nombre);
supprimerSortedSet(nombre);