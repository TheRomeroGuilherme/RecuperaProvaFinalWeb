import "./globals.css";
import Header from '../Components/Header/Header'
export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <Header></Header>
      <body>
        {children}
      </body>
    </html>
  );
}
