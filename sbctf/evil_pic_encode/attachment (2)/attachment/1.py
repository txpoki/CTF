import numpy as np
from PIL import Image
import scipy.fftpack as fft

def iFFT(i):
    return fft.ifft2(i)

def iArnold(img, key):
    for _ in range(key):
        r, c = img.shape[:2]
        p = np.zeros_like(img)
        a = 114
        b = 514
        for i in range(r):
            for j in range(c):
                x = (i - b * j) % r
                y = ((a * b - 1) * i - a * j) % c
                p[x, y] = img[i, j]
        img = p.copy()
    return img

def iFFT_decrypt(img, key):
    for _ in range(key):
        img = iFFT(img)
    return img

# 读取加密后的图像数组
encrypted_array = np.load("encrypted.npy").reshape(h, w, 3)

# 逆向操作：Arnold变换逆操作和傅里叶逆变换
for i in range(0, kh // 4):
    for j in range(0, kw // 4):
        for ii in range(i * 4, i * 4 + 5):
            for jj in range(j * 4, j * 4 + 5):
                if encrypted_array[ii, jj] == 1:
                    encrypted_array[
                        ii * size : (ii + 1) * size, jj * size : (jj + 1) * size
                    ] = iFFT_decrypt(
                        encrypted_array[
                            ii * size : (ii + 1) * size, jj * size : (jj + 1) * size
                        ],
                        key_array[ii, jj],
                    )
        for ii in range(i * 4 + 1, i * 4 + 4):
            for jj in range(j * 4 + 1, j * 4 + 4):
                encrypted_array[
                    ii * size : (ii + 1) * size, jj * size : (jj + 1) * size
                ] = iArnold(
                    encrypted_array[ii * size : (ii + 1) * size, jj * size : (jj + 1) * size],
                    key_array[ii, jj],
                )

# 将逆向操作后的图像保存
decrypted_img = Image.fromarray(np.round(encrypted_array[:oh, :ow, :]).astype(np.uint8))
decrypted_img.save("decrypted.png")
