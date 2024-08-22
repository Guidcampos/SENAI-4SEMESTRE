import React from 'react';
import '../Button/Button.css'

const Button = ({tipo, textoBotao, additionalClass}) => {
    return (
        <button  className={`button ${additionalClass} `} type={tipo}>{textoBotao}</button>
    );
};

export default Button;