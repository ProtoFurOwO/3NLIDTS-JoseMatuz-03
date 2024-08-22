# -*- coding: utf-8 -*-
"""
Created on Tue Aug 20 10:28:17 2024

@author: ProtofurOwO
"""

import tkinter as tk

def reset():
    entry1.delete(0, tk.END)
    entry1.insert(0, "0.0")
    entry2.delete(0, tk.END)
    entry2.insert(0, "0.0")

def ctf():
    celsius = float(entry2.get())
    fahrenheit = (celsius * 9 / 5) + 32
    entry1.delete(0, tk.END)
    entry1.insert(0, f"{fahrenheit:.2f}")
    
def ftc():
    fahrenheit = float(entry1.get())
    celsius = (fahrenheit -32) * 5 / 9
    entry2.delete(0, tk.END)
    entry2.insert(0, f"{celsius:.2f}")
    
aplicacion = tk.Tk()
aplicacion.title("Conversor de temperaturas")

lbl1 = tk.Label(aplicacion, text="Fahrenheit:")
lbl1.grid(row=0, column=0)

entry1 = tk.Entry(aplicacion)
entry1.grid(row=0,column=1)

btn1 = tk.Button(aplicacion, text="Convertir a Celsius", command=ftc)
btn1.grid(row=0,column=2)

lbl2 = tk.Label(aplicacion, text="Celsius:")
lbl2.grid(row=1, column=0)

entry2 = tk.Entry(aplicacion)
entry2.grid(row=1,column=1)

btn2 = tk.Button(aplicacion, text="Convertir a Fahrenheit", command=ctf)
btn2.grid(row=1,column=2)

btn3 = tk.Button(aplicacion, text="Reset", command=reset)
btn3.grid(row=2, column=1)

aplicacion.mainloop()