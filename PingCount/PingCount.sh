#!/bin/bash

if [ -z "$1" ]
then
echo "Merci de précisez l'URL !"
else


count=$(curl -s -m 2 $1/count | jq '.totalPing' 2>/dev/null)
if [ "$count" -eq "$count" 2>/dev/null ]
then  echo "La page fonctionne correctement"
else echo "La page ne fonctionne pas correctement"
exit 1
fi
pong=$(curl -s -m 2 $1/ping | jq '.message' 2>/dev/null)
 
    if [  $pong=="pong" ]
        then
        echo "Ping ... pong ... Retour gagnant"
    else
        echo "Ping ... La balle est tombé"
        exit 1
    fi
countTotal=$(curl -s -m 2 $1/count | jq '.totalPing' 2>/dev/null)-$count
    if [ $(echo $countTotal | bc) -eq 1 ]
    then
        echo "Counter fonctionnel , l'incrémentation marche"
    else
        echo "Counter non fonctionnel"
        exit 1
    fi
echo "Application fonctionnelle"
exit 0
fi
   
