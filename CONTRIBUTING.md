Bij dit project wordt gitflow gebruikt.

Maak nooit een commit direct op main.
Als er een hotfix nodig is maak je een branch met de naam hotfix/[naam] vanuit main. Merge de branch vervolgens met main EN dev.
Voor features maak je vanuit dev een branch met de naar feature/[naam] vanuit dev. Noem het nummer van de UC als het om een UC gaat in de naam van de branch. Maak zodra de feature af is een merge request naar dev aan.
Als alle features voor de volgende release af zijn wordt er vanuit dev een branch met de naam release gemaakt. Op de release branch mogen bugfixes worden gemaakt. Na het maken van de bugfix kan een merge gemaakt worden naar dev.
Als de belangrijke bugs opgelost zijn en het tijd is voor de release (op vrijdag) wordt er een merge request gemaakt van release naar main.