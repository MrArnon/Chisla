import matplotlib.pyplot as plt
import numpy as np
from scipy.integrate import odeint
from sympy.solvers import solve
from sympy import Symbol
def func_z (y) :
    return y+1
def func_y (z,x,y):
    return y*y/(z-x)
def y_eql_1 (x):
    return np.exp(x)
def z_eql_2 (x):
    return x+np.exp(x)
def painting (y,z):
    plots=plt.subplot()
    x=np.linspace(0, 1, 100)
    y1=y(x)
    y2=z(x)
    plots.plot(x,y1,color="orange")
    plots.plot(x, y2, color="green")
    plt.grid(True)
    plt.xlabel("Точное решение")
    plt.show()
def graphic (list_x,list_y,list_z,b):
    x = list_x
    y=list_y
    z=list_z
    plots = plt.subplot()
    plots.plot(x, y,'-o',color="orange")
    plots.plot (x,z,'-o',color="green")
    if b :
        plt.xlabel("Явный метод Эйлера")
    else :
        plt.xlabel("Неявный метод Эйлера")
    plt.grid(True)
    plt.show()
def eler_2 (list_y,xo,yo,list_x,list_z):
    h = float(0.1)
    y = yo
    x = xo
    list_x.append(x)
    list_z.append(y)
    i = float(0)  # interval x e[0,1]
    n=int(0)
    while i < 1:
        y += h * func_y(list_y[n],x,y)
        x += h
        list_x.append(x)
        # print("x",x)
        list_z.append(y)
        # print("y",y)
        i += h
        n+=1
def eler (f,xo,yo,list_x,list_y):
    h=float(0.1)
    y=yo
    x=xo
    list_x.append(x)
    list_y.append(y)
    i=float(0)#interval x e[0,1]
    while i<1:
        y+=h*f(y)
        x+=h
        list_x.append(x)
        #print("x",x)
        list_y.append(y)
        #print("y",y)
        i+=h
def sys_diff (f,x):
    y,z=f
    return [y*y/(z-x),y+1]
def new_eler():
    x = np.linspace(0, 1, 41)
    y0 = [1,1]  # start value
    w = odeint(sys_diff, y0, x)  # solve eq.
    y1 = w[:, 0]
    y2 = w[:, 1]
    plt.plot(x, y1,'-o',color="green")
    plt.plot( x, y2,'-o',color="blue")
    plt.xlabel("Решение")
    plt.grid(True)
    plt.show()  # display
def n_eler (f,xo,yo,list_x,list_y):
    h=float(0.1)
    y=yo
    x=xo
    list_x.append(x)
    list_y.append(y)
    i=float(0)#interval x e[0,1]
    n=int(0)
    while i<1:
        y1=Symbol('y1')
        yi1=(solve((y1-list_y[n])/h - f(y1),y1))
        x+=h
        list_x.append(x)
        #print("x",x)
        list_y.append(yi1[0])
        #print(list_y[n])
        i+=h
        n+=1
def n_eler_2(list_y,xo,yo,list_x,list_z):
    h=float(0.1)
    y=yo
    x=xo
    list_x.append(x)
    list_z.append(y)
    i=float(0)#interval x e[0,1]
    n=int(0)
    while i<1:
        y1=Symbol('y1')
        yi1=(solve((y1-list_z[n])/h - func_y(list_y[n],x,y1),y1))
        x+=h
        list_x.append(x)
        #print("x",x)
        list_z.append(yi1[0])
        #print(list_y[n])
        i+=h
        n+=1
def main():
    list_x=list()
    list_y=list()
    eler(func_z,0,1,list_x,list_y)#z(0)=1 явный метод первое уравнение
    list_x=list()
    list_z=list()
    eler_2 (list_y,0,1,list_x,list_z)#y(0)=1 явный метод второе уравнение
    graphic(list_x, list_y,list_z,True)#графики явного метода Эйлера
    list_x = list()
    list_y = list()
    n_eler(func_z,0,1,list_x,list_y)#z(0)=1 неявный метод 1е уравнение
    list_x = list()
    list_z = list()
    n_eler_2(list_y,0,1,list_x,list_z)#y(0)=1 неявный метод 2е уравнение
    graphic(list_x,list_y,list_z,False)#графики неявного метода Эйлера
    painting(z_eql_2,y_eql_1) #графики точных решений
main()



