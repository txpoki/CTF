import scipy.fftpack as fft
import numpy as np
from PIL import Image

img = Image.open("flag.png")
img_array = np.array(img)


def FFT(i):
    return fft.fft2(i)


def iFFT(i):
    return fft.ifft2(i)


def FFT_encrypt(img, key):
    for _ in range(key):
        img = FFT(img)
    return img


def arnold(img, key):
    for _ in range(key):
        r, c = img.shape[:2]
        p = np.zeros_like(img)
        a = 114
        b = 514
        for i in range(r):
            for j in range(c):
                x = (i + b * j) % r
                y = (a * i + (a * b + 1) * j) % c
                p[x, y] = img[i, j]
        img = p.copy()
    return img


size = 29
oh, ow = img_array.shape[:2]
h = oh
if h % size != 0:
    h += size - h % size

w = ow
if w % size != 0:
    w += size - w % size

new_array = np.ones((h, w, 3)) * 255
new_array[:oh, :ow, :] = img_array
kh = h // size
if kh % 4 != 1:
    kh += (1 - kh % 4) % 4

kw = w // size
if kw % 4 != 1:
    kw += (1 - kw % 4) % 4

key_array = np.zeros((kh, kw), dtype=np.int64)
for i in range(0, kh):
    for j in range(0, kw):
        if i % 4 == 0 or j % 4 == 0:
            key_array[i, j] = np.random.randint(1, 5)
encrypted_array = np.zeros_like(key_array)
added_array = np.zeros_like(key_array)
for i in range(0, kh // 4):
    for j in range(0, kw // 4):
        nk = 1
        for ii in range(i * 4, i * 4 + 5):
            for jj in range(j * 4, j * 4 + 5):
                if key_array[ii, jj] != 0 and encrypted_array[ii, jj] == 0:
                    if (
                        0
                        not in new_array[
                            ii * size : (ii + 1) * size, jj * size : (jj + 1) * size
                        ].shape
                    ):
                        new_array[
                            ii * size : (ii + 1) * size, jj * size : (jj + 1) * size
                        ] = FFT_encrypt(
                            new_array[
                                ii * size : (ii + 1) * size, jj * size : (jj + 1) * size
                            ],
                            key_array[ii, jj],
                        )
                        added_array[ii, jj] += key_array[ii, jj]
                    nk *= key_array[ii, jj]
                    encrypted_array[ii, jj] = 1
        for ii in range(i * 4 + 1, i * 4 + 4):
            for jj in range(j * 4 + 1, j * 4 + 4):
                key_array[ii, jj] = nk % 114514 % 1919810 % 53
                new_array[
                    ii * size : (ii + 1) * size, jj * size : (jj + 1) * size
                ] = arnold(
                    new_array[ii * size : (ii + 1) * size, jj * size : (jj + 1) * size],
                    key_array[ii, jj],
                )
img = Image.fromarray(np.round(new_array).astype(np.uint8))
np.save("encrypted", new_array.reshape(-1))
print(added_array)
