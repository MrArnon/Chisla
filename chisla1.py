import matplotlib.pyplot as plt
import numpy as np
from scipy.misc import derivative
def func_z (y) :
    #return (np.exp(x)+np.exp(-x))/2
   #return x*x +3
   return y+1
def func_y (z,x,y):
    return y*y/(z-x)
def y_eql_1 (x):
    return np.exp(x)
def z_eql_2 (x):
    return x+np.exp(x)
def diff_func(f,y):
    #print(derivative (func,x))
    return derivative (f,y)
def painting (x,y1,y2,y3):
    plots=plt.subplot()
    plots.plot(x,y1,color="blue",label="First")
    plots.plot(x, y2, color="green", label="Second")
    plots.plot(x, y3, color="red", label="")
    plots.legend()
    plots.show()
def graphic (list_x,list_y):
    x = list_x
    y=list_y
    plt.plot(x, y)
    plt.show()
def graphic_1(a,b,f):
    x = np.linspace(a, b, 1000)
    y=f(x)
    plt.plot(x,y)
    plt.show()
def eler (f,xo,yo,list_x,list_y):
    h=float(0.01)
    y=yo
    x=xo
    n=int(100)
    i=float(0)#interval x e[0,1]
    while i<1:
        y+=h*diff_func(f,y)
        x+=h
        list_x.append(x)
        list_y.append(y)
        i+=h
def main():
    list_x=list()
    list_y=list()
    eler(func_z,0,1,list_x,list_y)#z(0)=1
    graphic(list_x,list_y)
    graphic_1(0,1,z_eql_2)

main()

