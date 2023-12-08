def ascii_to_char(ascii_values):
    ascii_values = ascii_values.replace('&#', '').replace(';', ' ')
    return ''.join(chr(int(i)) for i in filter(None, ascii_values.split(' ')))

ascii_values = '&#75;&#69;&#89;&#123;&#74;&#50;&#115;&#97;&#52;&#50;&#97;&#104;&#74;&#75;&#45;&#72;&#83;&#49;&#49;&#73;&#73;&#73;&#125;'
print(ascii_to_char(ascii_values))
