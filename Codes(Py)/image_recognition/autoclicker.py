import time
import keyboard
import win32api, win32con

def click():
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN,0,0)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP,0,0)

while not keyboard.is_pressed('q'):
    click()
    time.sleep(.006)