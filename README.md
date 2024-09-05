# ToDoList
Cele 2 design patterns alese au fost:

1. Factory design pattern - clasa TaskFactory
Este utilizat pentru a crea obiecte fara a specifica exact ce tip de obiect va fi creat. In cazul de fata, TaskFactory implementeaza interfata ITaskFactory si are rolul de a crea instante ale claselor WorkTask sau PersonalTask, in functie de parametrul type.
Metoda CreateTask din TaskFactory decide tipul de sarcina de creat (WorkTask sau PersonalTask) pe baza valorii string-ului type.

2. Observer design pattern - clasa TaskList
Pattern-ul Observer permite ca un obiect (Observer) sa fie notificat automat cand un alt obiect (Subject) isi schimba starea.
In acest exemplu, TaskList actionează ca un Observer care "asculta" evenimentele TaskUpdated declansate de obiectele de tip Task (care sunt Observable).
Cand starea unei sarcini (Task) se modifica (cand se apelează metodele Start sau Complete), evenimentul TaskUpdated este declansat și notifica toate obiectele abonate, cum ar fi TaskList.
TaskList se aboneaza la acest eveniment atunci cand adauga o sarcină în lista (prin metoda AddTask) si se dezaboneaza cand elimina o sarcina (prin metoda RemoveTask).