var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/*
nome repo: la-mia-pizzeria-static
Ciao ragazzi oggi iniziamo a muovere i primi passi con questo fantastico Asp .Net Core MVC!
Dobbiamo realizzare un'applicazione web che ci aiuti a gestire la nostra pizzeria.
Abbiamo bisogno di creare la nostra prima pagina (index) dove mostriamo tutte le pizze che prepariamo.

Una pizza avr‡ le seguenti informazioni :
- un nome
- una descrizione
- una foto
- un prezzo

Modifichiamo quindi la view Index.cshtml generata in automatico da .Net Core scrivendo l'html che serve a noi per mostrare l'elenco delle pizze
(possiamo creare una tabella con bootstrap o una qualche grafica a nostro piacimento che mostri l'elenco delle pizze...proviamo un po' di creativit‡ se vogliamo!)
Piccolo suggerimento : ricordatevi di inserire il seguente codice all'inizio della vostra view @ { Layout = null; }
*/

/*
1. Dichiarare una variabile valorizzandola con il nostro nome.
Dichiarare un'altra variabile valorizzandola con il nostro cognome.
Stampare il nostro nome e cognome all'interno di un tag h2.

2. Creare una funzione che stampa la somma dei numeri che vanno da 1 a n (con n passato come parametro - n incluso)
Stampare dentro uno span il risultato.

3. Contare quante volte la lettera a A Ë presente nalla frase "nel mezzo del cammin di nostra vita" e stampare questo valore in pagina

4. Creare una List<int> di 20 numeri interi (generati random da 1 a 90, 1 e 90 inclusi) e mostrare in pagina solo i numeri compresi tra 20 e 70

5. Stampare in pagina la data e l'ora attuale (usando la classe DateTime) con il formato anno-mese-giorno ore:minuti:secondi

6. Partendo dalla data di oggi (usando la classe DateTime) stampare in pagina
a. la data di 7 giorni fa
b. che giorno della settimana √® oggi (il risultato dovr√  essere il nome del giorno (Luned√¨, Marted√¨, ...)
c. che giorno della settimana sar√  nello stesso giorno e mese di oggi ma tra un anno (il risultato dovr√  essere il nome del giorno (Luned√¨, Marted√¨, ...)
*/