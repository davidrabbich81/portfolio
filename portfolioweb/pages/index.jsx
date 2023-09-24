import About from "@/src/components/About";
import Contact from "@/src/components/Contact";
import Home from "@/src/components/Home";
import News from "@/src/components/News";
import Portfolio from "@/src/components/Portfolio";
import Services from "@/src/components/Skills";
import Layout from "@/src/layout/Layout";
const Index = () => {
  return (
    <Layout>
      <Home />
      <About />
      <Services />
      <Portfolio />
      <News />
      <Contact />
    </Layout>
  );
};
export default Index;
