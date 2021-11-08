# Dizionario_Offline

Il seguente programma implementa un semplice dizionario che lavora come un contenitore di parole e dei suoi significati.
E' Implementata un interfaccia grafica per semplificare il suo utilizzo.
La persistenza dei dati e' garantita attraverso serializzazione JSON.
L'inserimento di una parola viene acconsentito se l'utente inserisce correttamente una password di sistema, mentre la correttezza della password viene verificata attraverso una richiesta HTTP ad un Server implementato specificatamente per questo tipo di richiesta.
Il server si connette con un database MySql e ricerca se la password appartiene alla tabella delle password valide, in caso affermanetivo inviera' al client una risposta positiva, altrimenti una negativa.

Le funzionalita' del dizionario sono le seguenti: 
- Visualizzazione di tutte le parole
- Ricerca di parole che iniziano per una lettera
- Visualizzazione dei significati delle parole cercate
- Inserimento di una parola 
