/*
 Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de software
 y se notifica que su suscripción finaliza pronto.
*/
/*
 Regla 1. Si la suscripción del usuario expira en 10 días o menos, muestre el mensaje:
  Your subscription will expire soon. Renew now!

  Regla 2. Si la suscripción del usuario expira en cinco días o menos, muestre los mensajes:
    Your subscription expires in x days.
    Renew now and save 10%!

   Regla 3. Si la suscripción del usuario expira en un día, muestre el mensaje:
       Your subscription expires within a day!
       Renew now and save 20%!

   Regla 4. Si la suscripción del usuario ha expirado, muestre el mensaje:
        Your subscription has expired.

   Regla 5. Si la suscripción del usuario no expira en 10 días o menos, no muestre ningún mensaje.
 */
Random random = new Random();
int vencimientoSuscripcion = random.Next(12);
int porcentajeDescuento = 0;

if (vencimientoSuscripcion == 0)
{
    Console.WriteLine("Tu suscripcion ha vencido");

}else if (vencimientoSuscripcion == 1)
{
    porcentajeDescuento = 20;
    Console.WriteLine($"Tu suscripcion vence en  { vencimientoSuscripcion} dia, renova ahora y obtene {porcentajeDescuento}% de descuento");
}else if (vencimientoSuscripcion <= 5)
{
    porcentajeDescuento = 10;
    Console.WriteLine($"Tu suscripcion vence en  {vencimientoSuscripcion} dia, renova ahora y obtene {porcentajeDescuento}% de descuento");
}
else if (vencimientoSuscripcion <= 10)
{
    Console.WriteLine("Tu suscripcion vence en " + vencimientoSuscripcion + " dias, ¿Te gustaria renovar?");
}



