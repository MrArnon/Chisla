import matplotlib.pyplot as plt
import numpy as np
def func_z (y) :
    return y+1
def func_y (z,x,y):
    return y*y/(z-x)
def y_eql_1 (x):
    return np.exp(x)
def z_eql_2 (x):
    return x+np.exp(x)
def painting (y,z,list_x,list_y,list_z):
    plots=plt.subplot()
    x=np.linspace(0, 1, 100)
    y1=y(x)
    y2=z(x)
    plots.plot(x,y1,color="orange")
    plots.plot(x, y2, color="green")
    x = list_x
    y = list_y
    z = list_z
    plots.plot(x, y,'-o', color="red")
    plots.plot(x, z,'-o', color="yellow")
    plt.grid(True)
    plt.title("Graphic")
    plt.show()
def runge_kutt (f,xo,yo,list_x,list_y):
    h = float(0.1)
    y = yo
    x = xo
    list_x.append(x)
    list_y.append(y)
    i = float(0)  # interval x e[0,1]
    while i < 1:
        k1=h*f(y)
        k2=h*f(y+k1/2)
        k3=h*f(y+k2/2)
        k4=h*f(y+k3)
        y+=(k1+2*k2+2*k3+k4)/6
        x += h
        list_x.append(x)
        list_y.append(y)
        i += h
def runge_kutt_2(f,list_y,xo,yo,list_x,list_z):
    h = float(0.1)
    y = yo
    x = xo
    list_x.append(x)
    list_z.append(y)
    i = float(0)  # interval x e[0,1]
    n = int(0)
    while i < 1:
        k1 = h * f(list_y[n],x,y)
        k2 = h * f(list_y[n],x+h/2,y + k1 / 2)
        k3 = h * f(list_y[n],x+h/2,y + k2 / 2)
        k4 = h * f(list_y[n],x+h,y + k3)
        y += (k1 + 2 * k2 + 2 * k3 + k4) / 6
        x += h
        list_x.append(x)
        list_z.append(y)
        i += h
        n+=1
def main():
    list_x=list()
    list_y=list()
    runge_kutt(func_z,0,1,list_x,list_y) #четверный порядок точности
    list_x=list()
    list_z=list()
    runge_kutt_2(func_y,list_y,0,1,list_x,list_z)
    painting(z_eql_2,y_eql_1,list_x,list_y,list_z)
main()
