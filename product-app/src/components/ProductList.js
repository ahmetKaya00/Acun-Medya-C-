import React, { useEffect, useState } from "react";

const ProductList = () =>{
    const[products, setProducts] = useState([]);

    useEffect(()=>{
        fetch("http://localhost:5120/api/product")
            .then(response => {
                if(!response.ok){
                    throw new Error("Sunucudan veri alınamadı!")
                }
                return response.json();
            })
            .then(data => setProducts(data))
            .catch(error=>console.error("Hata: ", error));
    },[]);

    return (
        <div>
            <h2>Ürün Listesi</h2>
            <ul>
                {products.map(product => (
                    <li key={product.id}>
                        <strong>{product.name}</strong> - {product.price}₺
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default ProductList;