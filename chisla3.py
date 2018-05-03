import numpy as np
from scipy. integrate import odeint
import matplotlib.pyplot as plt
import math
import pylab

 # create function
def f(y, t):
    y1, y2 = y
    return [y1+1, y1*y1/(y2-t)]
def drange(start, stop, step):
    l = []
    r = start
    while r <= stop:
        l.append(r)
        r += step
    return l
def y_eql_1 (x):
    return np.exp(x)
def z_eql_2 (x):
    return x+np.exp(x)
t = np.linspace( 0, 3, 40) # vector of time
y0 = [0, 1] # start value
w = odeint(f, y0, t) # solve eq.
y1 = w[:,0]
y2 = w[:,1]
plots=plt.subplot()
t=np.linspace(0, 3, 40)
z2=y_eql_1(t)
z1=z_eql_2(t)
plots.plot(t,z1,color="orange")
plots.plot(t,z2, color="green")
plots.plot(t, y1, '-o', t, y2, '-o', linewidth=2)
plt.ylabel("z")
plt.xlabel("t")
plt.grid(True)
plt.show() # display
a, b = 0.0, 1.0
A, B = 0.0, 1+np.exp(1)
n = 5
h = (b - a) / n
D0, D1 = A + h, h

y = [[A, D0], [0, D1]]

def p(x):   return 1

def q(x):   return 1

def f(x):   return 3 * (math.e **x)

def get_c1():
    global n
    return (B - y[0][n]) / y[1][n]

def get_solv_y_i(i): return y[0][i] + get_c1() * y[1][i]

x = drange(a, b, h)

def div(a, b):
    return a / b

for i in range(1, n):
    y[0].append(
        div(
            (h ** 2 * f(x[i]) - (1.0 - (h / 2) * p(x[i])) * y[0][i - 1] - (h ** 2 * q(x[i]) - 2) * y[0][i]),
            1 + h / 2 * p(x[i])
        )
    )
    y[1].append(
        div(
            -(1 - h / 2 * p(x[i])) * y[1][i - 1] - (h ** 2 * q(x[i]) - 2) * y[1][i],
            1 + h / 2 * p(x[i])
        )
    )



for i in range(n):
    print(x[i], get_solv_y_i(i))

