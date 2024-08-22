import React, { useEffect, useState } from 'react';
import Button from '../../components/Button/Button';
import MainContent from '../../components/MainContent/MainContent';
import Container from '../../components/Container/Container';
import './HomePage.css'
import Input from '../../components/Input/Input';
import Task from '../../components/Task/Task';

const HomePage = () => {
    const [data, setData] = useState({
        diaSemana: '',
        ano: '',
        mes: '',
        dia: ''
      });

    const obterDataSeparada = () => {
        const options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
        const dataFormatada = new Date().toLocaleDateString('pt-BR', options);
    
        // Separar as partes da data
        const partes = dataFormatada.split(', ');
        const [diaSemana, diaMesAno] = partes;
        const [dia, mesAno] = diaMesAno.split(' de ');
        const [mes, ano] = mesAno.split(' ');
    
        return {
          diaSemana,
          ano,
          mes,
          dia
        };
      };

      useEffect(() => {
        setData(obterDataSeparada());
      }, []);
    
    
    return (
        <MainContent>
            <Container>
                <h1 className='diasemana' >{data.diaSemana}, <span className='dianumero'>{data.dia}</span> de {data.mes}</h1>
                <Input/>
                <Task/>
            </Container>
            <Button additionalClass={"button--pequeno"} tipo={"submit"} textoBotao={"Nova tarefa"} />
        </MainContent>
    );
};

export default HomePage;