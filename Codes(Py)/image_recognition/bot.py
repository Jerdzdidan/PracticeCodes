from pyautogui import *
import pyautogui
import time
import keyboard
import random
import win32api, win32con

# X: 726 Y:300 RGB: (0, 0, 0)
# X: 885 Y:300 RGB: (0, 0, 0)
# X: 1039 Y:300 RGB: (0, 0, 0)
# X: 1193 Y:300 RGB: (0, 0, 0)

def click(x, y):
    win32api.SetCursorPos((x, y))
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN,0,0)
    time.sleep(0.11) 
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP,0,0)

while not keyboard.is_pressed('q'):

    if pyautogui.pixel(726, 300)[1] == 0:
        click(726, 276)

    if pyautogui.pixel(885, 300)[1] == 0:
        click(885, 276)

    if pyautogui.pixel(1030, 300)[1] == 0:
        click(1030, 276)

    if pyautogui.pixel(1193, 300)[1] == 0:
        click(1193, 276)