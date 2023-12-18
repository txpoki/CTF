import hashlib
import itertools
import string

def custom_condition(md5_str):
    v14 = 0
    v13 = 0

    for j in range(32):
        if md5_str[j] == '0':
            v14 += 1
            v13 += j

    if 10 * v14 + v13 == 403:
        return True
    else:
        return False

def decode_function(encoded_str):
    # TODO: Implement your decode function logic here
    # This is a placeholder, you need to replace it with your actual decoding logic
    decoded_str = encoded_str
    print("Decoded String:", decoded_str)
    #ozulmt

def generate_and_check_strings():
    for s in itertools.product(string.ascii_lowercase, repeat=6):
        s = ''.join(s)
        md5_hash = hashlib.md5(s.encode()).hexdigest()
        
        if custom_condition(md5_hash):
            print(f"String: {s}, MD5 Hash: {md5_hash}")
            
           
         
            break  # Break after the first successful match

if __name__ == "__main__":
    generate_and_check_strings()
