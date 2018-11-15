<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/ArrayOfOrder">
    <html>
      <head>
        <title>Order</title>
      </head>
      <body>
        <ul>
          <xsl:for-each select="Order">                   
            <li>
              <xsl:value-of select="Id" />
            </li>
            <li>
              <xsl:value-of select="Customer/Name" />
            </li>
            <li>
              <xsl:value-of select="Customer/Phone" />
            </li>
            <li>
              <xsl:value-of select="Details/OrderDetail/Id" />
            </li>
            <li>
              <xsl:value-of select="Details/OrderDetail/Goods/Id" />
            </li>
            <li>
              <xsl:value-of select="Details/OrderDetail/Goods/Name" />
            </li>
            <li>
              <xsl:value-of select="Details/OrderDetail/Goods/Price" />
            </li>
            <li>
              <xsl:value-of select="Details/OrderDetail/Quantity" />
            </li>
          </xsl:for-each>
        </ul>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
