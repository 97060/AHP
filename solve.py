import sys
import ahpy;
import ast
import matplotlib.pyplot as plt
import numpy as np

param = ast.literal_eval(sys.argv[1])

def getResult(data):

    result = ahpy.Compare(name='Test', comparisons=data, precision=3, random_index='saaty')
    print("Wagi kryteriów(wektor własny unormowany): " + str(result.target_weights))
    print("Współczynnik CR: " + str(result.consistency_ratio))
    with open("wynik.txt", 'w', encoding="utf-8") as f:
        f.write("Wagi kryteriów(wektor własny unormowany): " + str(result.target_weights))
        f.write("\n")
        f.write("Współczynnik CR: " + str(result.consistency_ratio))

    matrix = result._matrix
    keys = list(result.target_weights.keys())
    values = list(result.target_weights.values())
    fig = plt.figure(figsize = (10,5))
    plt.bar(keys, values, color = 'red', width = 0.4)
    plt.title("Wykres słupkowy wartości wag kryteriów")
    plt.ylabel("Wagi kryteriów")
    plt.savefig("wykres.png")

    plt.figure()
    for row in range(len(matrix)):
        matrix[row] = np.round(matrix[row], 2)


    tb = plt.table(cellText=matrix, loc=(0,0), cellLoc='center')

    tc = tb.properties()['children']
    for cell in tc: 
        cell.set_height(1/len(values))
        cell.set_width(1/len(values))

    ax = plt.gca()
    ax.set_xticks([])
    ax.set_yticks([])
    plt.title("Macierz preferencji")
    plt.savefig("macierz.png")

getResult(param)
