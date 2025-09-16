edad = int(input("Ingrese la edad: "))

if edad >= 18:
    print("Elegible para votar")

    if edad >=25:
        print("Elegible para ser un candidato")
    else:
        print("No es elegile para ser candidato")
else:
    print("NO ES ELEGIBLE PARA VOTAR")