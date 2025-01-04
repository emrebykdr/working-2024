



# STRİNG İÇİN UYGULAMA 1
# title="Python için uygulama dersleri"
# # 1
# adet=len(title)
# print(adet)
# # 2
# print(title[:6])
# #3
# print(title[:5])
# print(title[-5:])
# #4
# print(title [::-1])  
# # 5
# ad = input('Adı giriniz')
# sad = input('Soyadı giriniz')
# not1 = input('not gir')
# not2 = input('not gir')
# ort= (float(not1) + float(not2)) / 2             
# sonuç=f"{ad} {sad} öğrencinin 1.notu {not1} ve 2.notu {not2} dir. Ortalaması: {ort} dur"
# print(sonuç)

# STRİNG İÇİN UYGULAMA 2

# 1


#FONKSİYONLAR UYGULAMA

# 1örnek
# def klm(text,adet):
#  return text * adet
# print(klm("Emre  ", 5))

# 2örnek
# def hesap(k,u):
#     alan=k*u
#     cevre= 2(k+u)
#     return f"alan : {alan} çevre {cevre}"
# sonuç=hesap(2,3)
# print(hesap)

# 3örnek
# def yt():
#     import random
#     sayi=random.random()
#     if sayi >0.5:
#         return "Yazı"
#     else:
#         return "Tura"
    
# sonuc= yt()

# print(sonuc)

# # 4 örnek
# def asal(sayi1,sayi2):
#     for sayi in range(sayi1,sayi2+1):
#         if (sayi>1):
#             for i in range(2,sayi1):
#                 if (sayi % i ==0):
#                     break 
#             else:
#                 print(sayi)
# asal(12,25)

# BANKAMATİK

# hesaplar =[
#     {
#         "ad": "Emre Büyükdere",
#         "hesapID":"01903",
#         "bakiye": 8600,
#         "eklimit":2000,
         
#     } ,
#       {
#         "ad": "Ayşe Büyükdere",
#         "hesapID":"01901",
#         "bakiye": 15000,
#         "eklimit":4000,
         
#     }
# ] 

# def menu(hesap):
#     print("\n")
#     print(f"Merhaba {hesap["ad"]}")
# def login():
#     login = input("hesapID")
#     print("1.BAKİYE")
#     print("1.PARA ÇEK")
   
#     isLoggedIn=False

#     for hesap in hesaplar:
#          if hesap ["hesapID"]:
#           isLoggedIn = True 
#           menu(hesap)
#           break
#     if not(isLoggedIn):
#        print("Yanlış ID girdiniz")
# login()

# islem=input("Yapılacaklar:")

# if islem == "1" :

# HATA YÖNTEMİ UYGULAMA
liste=["1","3","5","abc","10a","60"]
#1
# for x in liste:
#     try:
#      sonuç= int(x)
#      print(sonuç)
#      except ValueError:
#         continue
# 2
while True:
    sayi=input("sayi")
    if(sayi=="0"):
        break
sonuc=float(sayi)
print(f"girilen sayı:{sonuc}")    