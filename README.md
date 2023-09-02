# demoRabbitMQ: .NET Core Web API ile RabbitMQ Entegrasyonu 🚀

Merhaba! Bu proje, RabbitMQ kullanarak .NET Core tabanlı bir Web API uygulamasında iletişim kurmanızı sağlayacak temel bir yapıyı göstermektedir.

## Proje Yapısı 🏭
Projeyi "demoRabbitMQ" adıyla başlattık ve iki alt proje oluşturduk: "Core.Rabbitmq" ve "WebAPI". İşte yaptığımız adımlar:

### Core.Rabbitmq
- RabbitMQ entegrasyonu için bir arayüz tanımladık. Bu arayüz, RabbitMQ bağlantılarını yönetmek için gerekli olan standart bir yapı sağlar.
- Ardından, bu arayüzü uygulayan bir servis sınıfı olan "RabbitMqService" oluşturduk. Bu servis sınıfı, belirtilen URI'ye göre RabbitMQ bağlantılarını oluşturur ve yönetir.

### WebAPI
- Bu servisi enjekte etmek ve kullanmak için bir kayıt sınıfı ekledik. Bu kayıt, servisin WebAPI içinde erişilebilir hale gelmesini sağlar.
- WebAPI'nin "Program.cs" dosyasında, RabbitMQ servisini kaydederek servisin kullanılabilir hale gelmesini sağladık.
- Son olarak, WebAPI tarafında RabbitMQ ile bağlantı kurmayı mümkün kılan bir kontrolör oluşturduk. Bu kontrolör, URI'yi kullanarak RabbitMQ bağlantılarını oluşturur.

## Nasıl Başlayabilirsiniz 🌐
Projeyi yerel geliştirme ortamınıza klonlayın ve RabbitMQ bağlantı bilgilerinizi güncelleyin. Daha fazla ayrıntıyı projenin GitHub deposunda bulabilirsiniz.

## İlerleyen Süreç 🛠️🚀
Bu RabbitMQ serüveni bir başlangıçtır ve ilerleyen süreçte yeni özellikler ekleyerek ve iyileştirmeler yaparak geliştirmeyi planlıyoruz.

Teşekkür ederim ve projeyi incelemek için zaman ayırdığınız için minnettarız. Herhangi bir sorunuz veya öneriniz varsa lütfen GitHub deposu üzerinden bize bildirin.

**Kategoriler:** RabbitMQ, .NET Core, WebAPI, Teknoloji, Yazılım Geliştirme
