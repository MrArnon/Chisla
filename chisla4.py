import numpy as np
import matplotlib.pyplot as plt
import time
def solver(I, V, f, c, l, tau, gamma, T):
    K = int(round(T/tau))
    t = np.linspace(0, K*tau, K+1) # Сетка по времени
    dx = tau*c/float(gamma)
    N = int(round(l/dx))
    x = np.linspace(0, l, N+1) # Пространственная сетка
    C2 = gamma**2 # вспомогательная переменная
    if f is None or f == 0 :
        f = lambda x, t: 0
    if V is None or V == 0:
        V = lambda x: 0
    y = np.zeros(N+1) # Массив с решением на новом временном слое n+1
    y_1 = np.zeros(N+1) # Решение на предыдущем слое n
    y_2 = np.zeros(N+1) # Решение на слое n-1
    t0 = time.clock() # для измерения процессорного времени
    # Задаем начальное условие
    for i in range(0,N+1):
        y_1[i] = I(x[i])
    plot_u(y_1,x,t,0) #график
# Используем специальную формулу для расчета на первом
# временном шаге с учетом du/dt = 0
    n = 0
    for i in range(1, N):
        y[i] = y_1[i] + tau*V(x[i]) + \
            0.5*C2*(y_1[i-1] - 2*y_1[i] + y_1[i+1]) + \
            0.5*tau**2*f(x[i], t[n])
    y[0] = 0; y[N] = 0
    plot_u(y, x, t, 1)  # график
# Изменяем переменные перед переходом на следующий
# временной слой
    y_2[:] = y_1; y_1[:] = y
    for n in range(1, K):
# Пересчитываем значения во внутренних узлах сетки на слое n+1
        for i in range(1, N):
            y[i] = - y_2[i] + 2*y_1[i] + C2*(y_1[i-1] - 2*y_1[i] + y_1[i+1]) + tau**2*f(x[i], t[n])
        y[0] = 0; y[N] = 0 # Задаем граничные условия
        plot_u(y_2,x,t,n+1) #график
# Изменяем переменные перед переходом на следующий
# временной слой
        y_2[:] = y_1; y_1[:] = y
    cpu_time = t0 - time.clock()
    return y_1,y_2, y, x, t

def plot_u(u, x, t, n):
    plt.plot(x, u, 'r-')
    plt.xlabel='x'
    plt.ylabel='u'
    plt.title=('t=%f ' % t[n])
    plt.show()
def plot_u_st(u_1,u_2,u, x, t, n):
    #umin = -1.2 * 0.005;
    #umax = -umin
    plots=plt.subplot()
    plt.plot(x, u, '-r')
    plt.plot(x, u_1, '-b')
    plt.plot(x, u_2, '-y')
    #plt.axis(0, 1,umin,umax)
    plt.xlabel('x')
    plt.ylabel('u')
    plt.title('t=%f ' % t[n])
    #plt.plot(x,u)
    plt.show()
# Начальные данные отображаем на экране в течение 2 сек.
# Далее меду временными слоями пауза 0.2 сек.
    time.sleep(2) if t[n] == 0 else time.sleep(0.2)
l = 2
x0 = 0.8*l
a = 10
freq = 300
wavelength = 2*l
c = freq*wavelength
omega = 2*np.pi*freq
num_periods = 10
T = 2*np.pi/omega*num_periods

# Выбираем tau таким же, как при условии устойчивости для N=50
tau = l/50./c
def I(x):
    return a*x/x0 if x < x0 else a/(l-x0)*(l-x)
y_1,y_2,y,x,t=solver(I,0,0,c,l,tau,0.9,T)
#plot_u_st(y_1,y_2,y,x,t,1)


def test_quadratic():

    def u_exact(x, t):
        return x*(l-x)*(1 + 0.5*t)
    def I(x):
        return u_exact(x, 0)
    def V(x):
        return 0.5*u_exact(x, 0)
    def f(x, t):
        return 2*(1 + 0.5*t)*c**2
    l = 2.5
    c = 1.5
    gamma = 0.75
    N = 6 # Используем грубую сетку
    tau = gamma*(l/N)/c
    T = 18
    def assert_no_error(u, x, t, n):
        u_e = u_exact(x, t[n])
        diff = np.abs(u - u_e).max()
        tol = 1E-13
        assert diff < tol
    solver(I, V, f, c, l, tau, gamma, T,user_action=assert_no_error)


