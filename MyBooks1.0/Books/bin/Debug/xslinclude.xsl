<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">  
<html>
  <body>
    <h2>Отчет HTML</h2>
    <table border="1">
      <tr bgcolor="#9acd32">
        <th style="text-align:left">book</th>
        <th style="text-align:left">author</th>
 <th style="text-align:left">category</th>
	<th style="text-align:left">price</th>
      </tr>

    <xsl:for-each select="bookstore/book">  
<tr>
     <td><xsl:apply-templates select="title"/></td>
      <td><xsl:apply-templates select="autor"/></td>  
  <td><xsl:value-of select="category"/></td>  
      <td><xsl:apply-templates select="price"/></td>  
   </tr>
    </xsl:for-each>  

 </table>
</body>
</html>
</xsl:template>

</xsl:stylesheet>