
#-*- coding:utf-8 -*-
import cv2
import numpy as np


filepath = "//ares/Temporary/EV/tsurunuma/2020/20201005tsurunuma/Sony camera/MAH00023.MP4"

cap = cv2.VideoCapture(filepath)

while(cap.isOpened()):

    ret, frame = cap.read()
    frame=cv2.resize(frame, (192*5, 108*5));
    cv2.imshow("Frame", frame)

    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

cap.release()
cv2.destroyAllWindows()