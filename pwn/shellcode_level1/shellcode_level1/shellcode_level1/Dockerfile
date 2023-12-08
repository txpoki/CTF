FROM alpine

COPY \
      ./flag /flag  \
      ./shellcode_level1 /shellcode_level1  \
      ./glibc-2.35-r1.apk \
      /

RUN apk add --no-cache socat && \
    wget -q -O /etc/apk/keys/sgerrand.rsa.pub https://alpine-pkgs.sgerrand.com/sgerrand.rsa.pub && \
    adduser -D ctf && \
    apk add /glibc-2.35-r1.apk && \
    cp -r /usr/glibc-compat/lib64/ /

EXPOSE 10000

USER ctf

ENTRYPOINT [ "socat", "tcp-l:10000,reuseaddr,fork", "exec:'/shellcode_level1'" ]

